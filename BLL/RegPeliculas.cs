using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class RegPeliculas
    {
        public int PeliculasId { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public RegPeliculas()
        {
            this.PeliculasId = 0;
            this.Titulo = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriaId = 0;
            this.Descripcion = "";
        }

        public RegPeliculas(int peliculasid,string titulo,int ano,int calificacion,int imdb,int categoriaid, string descripcion)
        {
            this.PeliculasId = peliculasid;
            this.Titulo = titulo;
            this.Ano = ano;
            this.Calificacion = calificacion;
            this.IMDB = imdb;
            this.CategoriaId = categoriaid;
            this.Descripcion = descripcion;
        }


        public  bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();

            conexion.Ejecutar(String.Format("Insert Into Peliculas (Titulo,Ano,Calificacion,IMDB,CategoriaId,Descripcion) Values('{0}','{1}','{2}','{3}','{4}','{5}')", this.Titulo,this.Ano,this.Calificacion,this.IMDB,this.CategoriaId,this.Descripcion));

            return retorno;

        }

        public DataTable Consultar(string consulta)
        {
            ConexionDb conexion = new ConexionDb();

            return conexion.ObtenerDatos("select * from Peliculas where 1=1 and "+ consulta);
            
        }

    }
}
