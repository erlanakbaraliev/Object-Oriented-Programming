namespace Fun_Fair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Gallery> galleries = new List<Gallery>(); 

            Gallery gallery1 = new Gallery();
            Guest guest1 = new Guest("Guest 1");
            Guest guest2 = new Guest("Guest 2");

            Size s = S.s;
            Prize ball = new Ball(s);

            guest1.Visit(gallery1);
            guest1.Win(ball);

            guest2.Visit(gallery1);
            
            Size xl = XL.xl;
            Prize teddy = new Teddy(xl);

            guest2.Win(teddy);

            gallery1.Winner();
        }
    }
}
