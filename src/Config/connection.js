import sql from "mssql";

const dbSttings = {
    user : "sa",
    password: "secret2024",
    server: "DESKTOP-RS6824H\SERVERSQL",
    database: "TalentoECundi",
    options : {
        encrypt: false,
        trustServerCertificate: true
    }
}

export const getConnection = async () => {
    try{
        const pool = await sql.connect(dbSttings);
        return pool;
    }catch(error){
        console.error(error);
    }
}