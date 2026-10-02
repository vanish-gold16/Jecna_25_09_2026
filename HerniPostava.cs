using System.Reflection.Metadata.Ecma335;

class HerniPostava
{
    private int _hp;
    public int Hp
    {
        get { return _hp; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("HP cannot be lower than zero");
            }

            _hp = value;
        }
    }
    private int _currrentHp;
    public int CurrentHp
    {
        get { return _currrentHp; }
        set
        {
            if (value > _hp)
            {
                throw new ArgumentException("Current HP cannot be greater than max HP");
            }

            _currrentHp = value;
        }
    }
    private int _level;
    public int Level
    {
        get { return _level; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Level cannot be lower or equal 0");
            }

            _level = value;
        }
    }
    public int Percent
    {
        get { return _currrentHp * 100 / _hp; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Current HP cannot be lower than zero");
            }
            CurrentHp = value * _hp / 100;
        }
    }
    public bool isAlive
    {
        get { return StavPostavy == StavPostavy.Nazivu; }
    }
    public StavPostavy StavPostavy { get; private set; }

    public String Damage(int DamageHp)
    {
        if (DamageHp < 0)
        {
            throw new ArgumentException("Damage HP cannot be lower than zero");
        }
        CurrentHp -= DamageHp;
        if (_currrentHp <= 0)
        {
            StavPostavy = StavPostavy.Mrtva;
            return $"Character is dead. {DamageHp} damage taken";
        }
        return $"Damage taken. Current HP: {_currrentHp}";
    }

    public String Heal(int HealHp)
    {
        if (HealHp < 0)
        {
            throw new ArgumentException("Heal XP cannot be lower than zero");
        }
        if (StavPostavy == StavPostavy.Mrtva)
        {
            return "Cannot heal dead character";
        }
        CurrentHp += HealHp;
        return $"Heal taken. Current HP: {_currrentHp}";
    }

    public String Revive()
    {
        if (StavPostavy == StavPostavy.Nazivu)
        {
            throw new ArgumentException("Nelze ozivit zivou postavu");
        }
        StavPostavy = StavPostavy.Nazivu;
        CurrentHp = Hp / 2;

        return $"Character revived. Current HP is {_currrentHp}";
    }

}

enum StavPostavy
{
    Nazivu, Mrtva
}