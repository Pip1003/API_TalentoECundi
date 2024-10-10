import Egresado from '../Models/EgresadoModel.js';
import EgresadoTitulo from '../Models/EgresadoTituloModel.js';

export const actualizarPerfilEgresado = async (req, res) => {
    const { id } = req.params; 
    const {
        nombres,
        apellidos,
        codigo_estudiante,
        fecha_nacimiento,
        genero,
        ano_graduacion,
        telefono,
        id_residencia,
        titulos, 
        imagen_perfil, 
        curriculum 
    } = req.body;

    try {
        // Buscar el egresado en la base de datos
        const egresado = await Egresado.findByPk(id);
        if (!egresado) {
            return res.status(404).json({ message: 'Egresado no encontrado' });
        }

        // Actualizar los datos de Egresado
        await egresado.update({
            nombres: nombres || egresado.nombres,
            apellidos: apellidos || egresado.apellidos,
            codigo_estudiante: codigo_estudiante || egresado.codigo_estudiante,
            fecha_nacimiento: fecha_nacimiento || egresado.fecha_nacimiento,
            genero: genero || egresado.genero,
            ano_graduacion: ano_graduacion || egresado.ano_graduacion,
            telefono: telefono || egresado.telefono,
            id_residencia: id_residencia || egresado.id_residencia,
            imagen_perfil: imagen_perfil || egresado.imagen_perfil,
            curriculum: curriculum || egresado.curriculum 
        });

        // Manejo de los títulos
        if (titulos && titulos.length > 0) {
            for (const titulo of titulos) {
                // Crear la relación en Egresado_Titulo con el estado y el id_titulo
                await EgresadoTitulo.create({
                    id_egresado: egresado.id,
                    id_titulo: titulo.id_titulo, 
                    estado: titulo.estado 
                });
            }
        }

        res.status(200).json({ message: 'Perfil actualizado correctamente' });
    } catch (error) {
        console.error(error);
        res.status(500).json({ message: 'Error en el servidor al actualizar el perfil' });
    }
};
