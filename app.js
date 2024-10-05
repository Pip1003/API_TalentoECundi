import express from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import { connectDatabase } from './src/Config/connection.js';

// Importe de modelos
import './src/Models/TestModel.js';
import './src/Models/PreguntaModel.js';
import './src/Models/OpcionModel.js';
import './src/Models/HabilidadModel.js';
import './src/Models/HabilidadPreguntaModel.js';

// Importar las relaciones entre modelos
import './src/Config/relationships.js';

// Importe de Middlewares
import { verifyToken } from './src/Middlewares/verificarToken.js';

//Importe de rutas
import registroRoutes from './src/Routes/RegistroRoutes.js';
import loginRoutes from './src/Routes/LoginRoutes.js';
import RecuperarRoutes from './src/Routes/RecuperarRoutes.js';
import TestRoutes from './src/Routes/TestRoutes.js';

const app = express();

//Conexión a la base de datos
connectDatabase();

// Middlewares de configuración
app.use(cors());
app.use(bodyParser.json({ type: 'application/json', limit: '10mb' }));//recibe un cuerpo y un objeto json
app.use(bodyParser.urlencoded({ extended: false })); //recibe url codificada

// Rutas
app.use('/api/v1', registroRoutes);
app.use('/api/v1', loginRoutes);
app.use('/api/v1', RecuperarRoutes);
app.use('/api/v1', TestRoutes);

const PORT = process.env.PORT || 5000;
app.listen(PORT, () => {
    console.log(`Servidor corriendo en el puerto ${PORT}`);
});