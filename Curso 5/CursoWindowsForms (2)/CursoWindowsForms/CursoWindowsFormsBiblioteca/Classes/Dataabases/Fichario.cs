﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Classes.Dataabases
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;
        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!Directory.Exists(Diretorio))
                {
                    Directory.CreateDirectory(Diretorio);
                }

                diretorio = Diretorio;
                mensagem = "Conexão com o fichário criada com sucesso.";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichário com erro: " + ex.Message;
            }




        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;

            try
            {
                if (File.Exists(diretorio + "//" + Id + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida, pois o identificador já existe: " + Id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso: " + Id;
                }
            }
            catch(Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichário com erro: " + ex.Message;
            }


        }
    }
}
