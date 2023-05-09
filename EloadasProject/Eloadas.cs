namespace EloadasProject
{
    internal class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama <= 0 || helyekSzama <= 0)
                throw new ArgumentException("A paramétereknek 0-nál nagyobbnak kell lennnie!");
            foglalasok = new bool[sorokSzama, helyekSzama];
        }

        public bool Lefoglal()
        {
            for (int sor = 0; sor < foglalasok.GetLength(0); sor++)
            {
                for (int hely = 0; hely < foglalasok.GetLength(1); hely++)
                {
                    if (!foglalasok[sor, hely])
                    {
                        foglalasok[sor, hely] = true;
                        return true;
                    }
                }
            }
            return false;
        }

        public int SzabadHelyek
        {

            get
            {
                int szabadHelyek = 0;
                for (int sor = 0; sor < foglalasok.GetLength(0); sor++)
                {
                    for (int hely = 0; hely < foglalasok.GetLength(1); hely++)
                    {
                        if (!foglalasok[sor, hely])
                        {
                            szabadHelyek++;
                        }
                    }
                }

                return szabadHelyek;
            }
        }

        public bool Teli
        {
            get
            {
                for (int sor = 0; sor < foglalasok.GetLength(0); sor++)
                {
                    for (int hely = 0; hely < foglalasok.GetLength(1); hely++)
                    {
                        if (!foglalasok[sor, hely])
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam <= 0 || helySzam <= 0 || sorSzam > foglalasok.GetLength(0) || helySzam > foglalasok.GetLength(1))
                throw new ArgumentException("Az érvénytelen paraméterek miatt nem lehet lekérdezni a helyfoglalást!");
                
            return foglalasok[sorSzam-1, helySzam-1];
        }
    }
}