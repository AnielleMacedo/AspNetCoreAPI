using APIGetListaMacchine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace APIGetListaMacchine.Controllers
{
    [Route("api/Manutenzione")]
    [ApiController]
    public class ManutenzioneController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ManutenzioneController(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult GetListaMacchine()
        {
            string query = @"select * from tbl_manutenzione";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultCon");
            MySqlDataReader myReader;
            using (MySqlConnection con = new MySqlConnection(sqlDataSource))
            {
                con.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, con))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    con.Close();
                }
            }

            return new JsonResult(table);
        }


        //scrivere tutti i campi nel post
        [HttpPost]
        public JsonResult PostMacchina(ManutenzioneModel macchina)
        {
            string query = @"insert into tbl_manutenzione 
                        (cod_macchina, des_macchina, id_tipo_get_macchina ,modello, marca) values
                         (@cod_macchina,@des_macchina,@id_tipo_get_macchina, @modello,@marca);";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultCon");

            MySqlDataReader myReader;

            using (MySqlConnection con = new MySqlConnection(sqlDataSource))
            {
                con.Open();

                using (MySqlCommand myCommand = new MySqlCommand(query, con))
                {
                    myCommand.Parameters.AddWithValue("@cod_macchina", macchina.CodMacchina);
                    myCommand.Parameters.AddWithValue("@des_macchina", macchina.DesMacchina);
                    myCommand.Parameters.AddWithValue("@id_tipo_get_macchina", macchina.IdTipoGetMacchina);
                    myCommand.Parameters.AddWithValue("@modello", macchina.Modello);
                    myCommand.Parameters.AddWithValue("@marca", macchina.Marca);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    con.Close();
                }
            }

            return new JsonResult("I campi sono stati aggiunti!");
        }


    }
}
