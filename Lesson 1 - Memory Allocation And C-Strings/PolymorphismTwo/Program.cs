
public class Program
{
    // Database of cats
    private static IAnimal[] animalDatabase;

    public static void Main(string[] args)
    {
        // Instantiate an IDamageable
        // Classes that implment the interface will
        // automatically be cast to the interface type
        IDamageable asteroid = new Asteroid();
        IDamageable rocket = new Rocket();

        List<IDamageable> damageables = new List<IDamageable>();

        // Add a rocket and asteroid to damageables collection
        damageables.Add(asteroid);
        damageables.Add(rocket);

        // Hit everything in the list for 50 damage
        foreach(var dmgable in damageables)
        {
            dmgable.Hit(50);
        }

        List<IDamageable> randomDamageables = new List<IDamageable>()
        {
            new Asteroid(),
            new Rocket(),
            new Rocket(),
            new Asteroid(),
            new Asteroid(),
            new Asteroid()
        };

        // Hit all asteroids for 50 damage
        foreach(var dmgable in randomDamageables)
        {
            // 1
            if (dmgable.GetType() == typeof(Asteroid))
            {
                dmgable.Hit(50);
            }

            // 2
            if(dmgable is Asteroid)
            {
                dmgable.Hit(50);
            }

            // 3 implcit casting
            Asteroid a = dmgable as Asteroid;

            // when you do implicit casting, there is a possiblity
            // that the cast can fail. So you have to check for null!
            if(a != null)
            {
                a.Hit(50);
            }

            // 4 explicit casting
            Asteroid b = (Asteroid)dmgable;
            b.Hit(50);
        }

        IHero tracer = new Tracer();
        IHero winton = new Winton();

        // Make a hero attack another hero
        // if that hero is dead, print "He die"
        // otherwise, print "no one die"
        winton.Attack(tracer);
        if (tracer.IsDead)
        {
            Console.WriteLine("He die");
        }
        else
        {
            Console.WriteLine("No one die");
        }
    }
}