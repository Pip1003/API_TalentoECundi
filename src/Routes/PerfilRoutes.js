import express from 'express';
import multer from 'multer';

import { 
    actualizarPerfilEgresado, 
    obtenerPerfilYResultadosEgresado, 
    obtenerPerfilEgresado, 
    actualizarPerfilEmpresa, 
    obtenerPerfilEmpresa 
} from '../Controllers/PerfilController.js';

// Configuración de multer para manejar la subida de imágenes
const storage = multer.memoryStorage();
const upload = multer({ storage });

const uploadFields = upload.fields([
  { name: 'logo', maxCount: 1 },
  { name: 'banner', maxCount: 1 }
]);

const uploadFieldsEgresado = upload.fields([
    { name: 'imagen_perfil', maxCount: 1 },
    { name: 'curriculum', maxCount: 1 },
  ]);

const router = express.Router();

router.put('/perfilEgresado/:id', uploadFieldsEgresado ,actualizarPerfilEgresado);
router.get('/perfilEgresado/:id', obtenerPerfilYResultadosEgresado);
router.get('/perfilEgresado/actualizar/:id', uploadFieldsEgresado , obtenerPerfilEgresado);
router.put('/perfilEmpresa/:id',  uploadFields, actualizarPerfilEmpresa);
router.get('/perfilEmpresa/:id', obtenerPerfilEmpresa);

export default router;
