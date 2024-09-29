import express from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import { getConnection } from './connection.js';

const app = express();

// Middlewares
app.use(cors());
app.use(bodyParser.json());

app.get('/api/data', async (req, res) => {
    try {
        const pool = await getConnection();
        const result = await pool.request().query('SELECT GETDATE()');
        res.json(result.recordset);
    } catch (error) {
        console.error('Error al realizar la consulta: ', error);
        res.status(500).send('Error en el servidor');
    }
});

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
    console.log(`Servidor corriendo en el puerto ${PORT}`);
});