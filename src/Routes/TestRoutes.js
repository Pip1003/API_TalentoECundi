import express from 'express';
import { 
    crearTest, 
    obtenerTestConDetalles, 
    agregarPreguntas, 
    guardarYCalcularRespuestas,
    obtenerResultadosConHabilidades,
    obtenerEstadoTestEgresado
} from '../Controllers/TestController.js';

const router = express.Router();

router.post('/crear-test', crearTest);
router.get('/test/:id', obtenerTestConDetalles);
router.post('/test/:id/preguntas', agregarPreguntas);
router.post('/test/:test_id/respuestas', guardarYCalcularRespuestas);
router.get('/test/:id_egresado/resultados', obtenerResultadosConHabilidades);
router.get('/test/:test_id/egresado/:egresado_id/estado', obtenerEstadoTestEgresado);


export default router;
