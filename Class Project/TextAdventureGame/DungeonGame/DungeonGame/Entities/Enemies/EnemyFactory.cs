namespace GameMath.Enemies;

public class EnemyFactory
{
    public static T CreateEnemy<T>(char enemyCode) where T : Enemy
    {
        if (enemyCode < '0' || enemyCode > '9')
        {
            return default;
        }

        Enemy result = null;
        switch (enemyCode)
        {
            case '0':
                result = new Skeleton();
                break;
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                result = new Enemy();
                break;
        }
        
        return result as T;
    }
}
