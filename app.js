import express from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import { connectDatabase } from './src/Config/connection.js';

const app = express();

connectDatabase();

// Middlewares
app.use(cors());
app.use(bodyParser.json({ type: 'application/json', limit: '10mb' }));//recibe un cuerpo y un objeto json
app.use(bodyParser.urlencoded({ extended: false }));//recibe url codificada



const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
    console.log(`Servidor corriendo en el puerto ${PORT}`);
});