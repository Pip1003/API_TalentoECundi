import express from 'express';
import { actualizarPerfilEgresado } from '../Controllers/PerfilController.js';

const router = express.Router();

router.put('/perfilEgresado/:id', actualizarPerfilEgresado);

export default router;
