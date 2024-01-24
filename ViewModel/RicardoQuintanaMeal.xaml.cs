using Newtonsoft.Json;

namespace Quintana_Progreso3.ViewModel;

public partial class RicardoQuintanaMeal : ContentPage
{
    internal class MealAPI
    {
        public static async Task<string> GetRandomMeal()
        {
            string url = "https://www.themealdb.com/api/json/v1/1/random.php";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Rootobject>(json);
                    var r_meal = obj.meals[0];

                    return "Id: " + r_meal.idMeal.ToString() + "\nNombre: " + r_meal.strMeal + "\nCategoria: " + r_meal.strCategory;
                }
            }
            return null;

        }

        public class Rootobject
        {
            public Meal[] meals { get; set; }
        }

        public class Meal
        {
            public string idMeal { get; set; }
            public string strMeal { get; set; }
            public object strDrinkAlternate { get; set; }
            public string strCategory { get; set; }
            public string strArea { get; set; }
            public string strInstructions { get; set; }
            public string strMealThumb { get; set; }
            public string strTags { get; set; }
            public string strYoutube { get; set; }
            public string strIngredient1 { get; set; }
            public string strIngredient2 { get; set; }
            public string strIngredient3 { get; set; }
            public string strIngredient4 { get; set; }
            public string strIngredient5 { get; set; }
            public string strIngredient6 { get; set; }
            public string strIngredient7 { get; set; }
            public string strIngredient8 { get; set; }
            public string strIngredient9 { get; set; }
            public string strIngredient10 { get; set; }
            public string strIngredient11 { get; set; }
            public string strIngredient12 { get; set; }
            public string strIngredient13 { get; set; }
            public string strIngredient14 { get; set; }
            public string strIngredient15 { get; set; }
            public string strIngredient16 { get; set; }
            public string strIngredient17 { get; set; }
            public string strIngredient18 { get; set; }
            public string strIngredient19 { get; set; }
            public string strIngredient20 { get; set; }
            public string strMeasure1 { get; set; }
            public string strMeasure2 { get; set; }
            public string strMeasure3 { get; set; }
            public string strMeasure4 { get; set; }
            public string strMeasure5 { get; set; }
            public string strMeasure6 { get; set; }
            public string strMeasure7 { get; set; }
            public string strMeasure8 { get; set; }
            public string strMeasure9 { get; set; }
            public string strMeasure10 { get; set; }
            public string strMeasure11 { get; set; }
            public string strMeasure12 { get; set; }
            public string strMeasure13 { get; set; }
            public string strMeasure14 { get; set; }
            public string strMeasure15 { get; set; }
            public string strMeasure16 { get; set; }
            public string strMeasure17 { get; set; }
            public string strMeasure18 { get; set; }
            public string strMeasure19 { get; set; }
            public string strMeasure20 { get; set; }
            public string strSource { get; set; }
            public object strImageSource { get; set; }
            public object strCreativeCommonsConfirmed { get; set; }
            public object dateModified { get; set; }
        }

    }
}