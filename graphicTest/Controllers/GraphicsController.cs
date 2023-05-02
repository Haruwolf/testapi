using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Timers;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphicsController : ControllerBase
    {
        private List<IDictionary<string, object>> categories;
        private System.Timers.Timer timer;
        private Random random;

        public GraphicsController()
        {
            // Define as informações de cada categoria
            var category1 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 1"},
                {"Cor", "Azul"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category2 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 2"},
                {"Cor", "Verde"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category3 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 3"},
                {"Cor", "Vermelho"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category4 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 4"},
                {"Cor", "Amarelo"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category5 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 5"},
                {"Cor", "Roxo"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category6 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 6"},
                {"Cor", "Cinza"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category7 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 7"},
                {"Cor", "Laranja"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category8 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 8"},
                {"Cor", "Marrom"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };
            var category9 = new Dictionary<string, object>
            {
                {"Nome", "Categoria 9"},
                {"Cor", "Rosa"},
                {"Valor", 0},
                {"ValorMaximo", 200}
            };

            categories = new List<IDictionary<string, object>>()
            {
                category1,
                category2,
                category3,
                category4,
                category5,
                category6,
                category7,
                category8,
                category9
            };

            random = new Random();
        }

        [HttpGet]
        public ActionResult<IEnumerable<IDictionary<string, object>>> GetCategories()
        {
            foreach (var category in categories)
            {
                category["Valor"] = random.Next(50, (int)category["ValorMaximo"]);
            }

            return categories;
        }

    }
}