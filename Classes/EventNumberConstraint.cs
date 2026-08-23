namespace Portfolio.Classes
{
    public class EvenNumberConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var isInt = int.TryParse(values[routeKey]?.ToString(), out int number);

            if (isInt && number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
