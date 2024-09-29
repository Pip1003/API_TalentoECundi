import mysql from 'mysql2';
import settings from './config.json' assert { type: 'json' }; // Se añade la aserción de tipo JSON

let connection;

export async function connectDatabase() {
  if (!connection) {
    connection = await mysql.createConnection(settings);

    connection.connect(function (err) {
      if (!err) {
        console.log('Base de Datos Conectada');
      } else {
        console.log('Error en la conexión con la Base de Datos: ' + err);
      }
    });
  }
  return connection;
}


