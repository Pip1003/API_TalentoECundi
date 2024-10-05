import Test from '../Models/TestModel.js';
import Pregunta from '../Models/PreguntaModel.js';
import Opcion from '../Models/OpcionModel.js';
import Habilidad from '../Models/HabilidadModel.js';
import HabilidadPregunta from '../Models/HabilidadPreguntaModel.js';


Test.hasMany(Pregunta, { foreignKey: 'test_id', as: 'preguntas' });
Pregunta.belongsTo(Test, { foreignKey: 'test_id', as: 'test' });
Pregunta.hasMany(Opcion, { foreignKey: 'pregunta_id', as: 'opciones' });
Opcion.belongsTo(Pregunta, { foreignKey: 'pregunta_id', as: 'pregunta' });

Pregunta.belongsToMany(Habilidad, {
  through: HabilidadPregunta,
  foreignKey: 'pregunta_id',
  as: 'habilidades',
});


Habilidad.belongsToMany(Pregunta, {
  through: HabilidadPregunta,
  foreignKey: 'habilidad_id',
  as: 'preguntas',
});
