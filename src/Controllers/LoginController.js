import bcrypt from 'bcrypt';
import Usuario from '../Models/UsuarioModel.js';
import Egresado from '../Models/EgresadoModel.js';
import Empresa from '../Models/EmpresaModel.js'; 
import jwt from 'jsonwebtoken';

export const login = async (req, res) => {
    const { correo, contrasena } = req.body;

    try {
        // Verificar si el usuario existe
        const usuario = await Usuario.findOne({ where: { correo } });
        if (!usuario) {
            return res.status(404).json({ message: 'Usuario no encontrado' });
        }

        // Comparar contraseñas
        const contrasenaValida = await bcrypt.compare(contrasena, usuario.contrasena);
        if (!contrasenaValida) {
            return res.status(401).json({ message: 'Contraseña incorrecta' });
        }

        // Crear un token JWT
        const token = jwt.sign(
            { id: usuario.id, correo: usuario.correo, id_rol: usuario.id_rol },
            'udec2024', 
            { expiresIn: '1h' }
        );

        let id_relacionado = null;
        let imagen = null;

        // Verificar el rol del usuario
        if (usuario.id_rol === 1) {
            // Si es un egresado, obtener el id_egresado y la imagen
            const egresado = await Egresado.findOne({ where: { id_usuario: usuario.id } });
            id_relacionado = egresado ? egresado.id : null;
            imagen = egresado.imagen_perfil
             ? egresado.imagen_perfil.toString('base64') : null;
        } else if (usuario.id_rol === 2) {
            // Si es un empresasario, obtener el id_empresa y la imagen
            const empresario = await Empresa.findOne({ where: { id_usuario: usuario.id } });
            id_relacionado = empresario ? empresario.id : null;
            imagen = empresario.logo ? empresario.logo.toString('base64') : null;
        }

        // Responder con el token y los datos del usuario
        res.status(200).json({
            message: 'Inicio de sesión exitoso',
            token,
            usuario: {
                id: usuario.id,
                correo: usuario.correo,
                id_rol: usuario.id_rol,
                id_relacionado,
                imagen
            }
        });
    } catch (error) {
        console.error(error);
        res.status(500).json({ message: 'Error en el servidor' });
    }
};