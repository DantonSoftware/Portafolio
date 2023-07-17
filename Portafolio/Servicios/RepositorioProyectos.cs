using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "http://amazon.com",
                    ImagenUrl = "/imagenes/amazon.png"
                },
                new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion = "Pagina de noticias en React",
                    Link = "http://nytimes.com",
                    ImagenUrl = "/imagenes/nyt.png"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red Social para compartir en comunidades",
                    Link = "http://reddit.com",
                    ImagenUrl = "/imagenes/reddit.png"
                },
                new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar videojuegos",
                    Link = "http://store.steampowered.com",
                    ImagenUrl = "/imagenes/steam.png"
                },
            };
        }
    }
}
