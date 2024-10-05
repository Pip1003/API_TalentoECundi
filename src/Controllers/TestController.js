import Test from '../Models/TestModel.js';
import Pregunta from '../Models/PreguntaModel.js';
import Opcion from '../Models/OpcionModel.js';
import Habilidad from '../Models/HabilidadModel.js';
import HabilidadPregunta from '../Models/HabilidadPreguntaModel.js';
import sequelize from '../Config/connection.js';

export const crearTestConPreguntas = async (req, res) => {
  const { nombre, tiempo_minutos, preguntas } = req.body;

  const transaction = await sequelize.transaction();

  try {
    // Crear el test
    const test = await Test.create({ nombre, tiempo_minutos }, { transaction });

    // Recorrer las preguntas para crearlas
    for (const preguntaData of preguntas) {
      const { contenido, imagen, opciones, habilidades } = preguntaData;

      // Crear la pregunta
      const pregunta = await Pregunta.create(
        { contenido, imagen, test_id: test.id },
        { transaction }
      );

      // Crear las opciones para la pregunta
      for (const opcionData of opciones) {
        await Opcion.create(
          { contenido: opcionData.contenido, respuesta: opcionData.respuesta, pregunta_id: pregunta.id },
          { transaction }
        );
      }

      // Asociar habilidades a la pregunta
      for (const habilidadId of habilidades) {
        await HabilidadPregunta.create(
          { habilidad_id: habilidadId, pregunta_id: pregunta.id },
          { transaction }
        );
      }
    }

    // Confirmar la transacción
    await transaction.commit();

    res.status(201).json({ message: 'Test creado exitosamente', test });
  } catch (error) {
    // Revertir en caso de error
    await transaction.rollback();
    console.error(error);
    res.status(500).json({ message: 'Error creando el test', error });
  }
};

export const obtenerTestConDetalles = async (req, res) => {
    const { id } = req.params;

    try {
        const test = await Test.findOne({
            where: { id },
            include: [
                {
                    model: Pregunta,
                    as: 'preguntas',
                    include: [
                        {
                            model: Opcion,
                            as: 'opciones',
                        },
                        {
                            model: Habilidad,
                            as: 'habilidades',
                            through: {
                                model: HabilidadPregunta,
                                attributes: []
                            }
                        }
                    ]
                }
            ]
        });

        if (!test) {
            return res.status(404).json({ message: 'Test no encontrado' });
        }

        res.status(200).json(test);
    } catch (error) {
        console.error(error);
        res.status(500).json({ message: 'Error al obtener el test', error });
    }
};

export const agregarPreguntas = async (req, res) => {
    const { test_id, preguntas } = req.body; 
  
    const transaction = await sequelize.transaction();
  
    try {
      // Buscar si el test existe
      const test = await Test.findByPk(test_id);
      if (!test) {
        return res.status(404).json({ message: 'El test no existe' });
      }
  
      // Recorrer las nuevas preguntas para agregarlas al test
      for (const preguntaData of preguntas) {
        const { contenido, imagen, opciones, habilidades } = preguntaData;
  
        // Crear la nueva pregunta asociada al test
        const pregunta = await Pregunta.create(
          { contenido, imagen, test_id: test.id },
          { transaction }
        );
  
        // Crear las opciones para la pregunta
        for (const opcionData of opciones) {
          await Opcion.create(
            { contenido: opcionData.contenido, respuesta: opcionData.respuesta, pregunta_id: pregunta.id },
            { transaction }
          );
        }
  
        // Asociar habilidades a la pregunta
        for (const habilidadId of habilidades) {
          await HabilidadPregunta.create(
            { habilidad_id: habilidadId, pregunta_id: pregunta.id },
            { transaction }
          );
        }
      }
  
      // Confirmar la transacción
      await transaction.commit();
  
      res.status(201).json({ message: 'Preguntas agregadas exitosamente', test });
    } catch (error) {
      // Revertir en caso de error
      await transaction.rollback();
      console.error(error);
      res.status(500).json({ message: 'Error agregando preguntas', error });
    }
  };
