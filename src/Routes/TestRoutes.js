// TestRoutes.js
import express from 'express';
import { crearTestConPreguntas, obtenerTestConDetalles, agregarPreguntas } from '../Controllers/TestController.js';

const router = express.Router();

router.post('/crear-test', crearTestConPreguntas);
router.get('/test/:id', obtenerTestConDetalles);
router.post('/test/:id/preguntas', agregarPreguntas);

export default router;
