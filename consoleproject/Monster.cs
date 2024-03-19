using System;
using System.Collections.Generic;

namespace consoleproject
{

    public class Monster
    {
        private static Monster instance;
        public static Monster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Monster();
                }
                return instance;
            }
        }

        private Dictionary<string, List<string>> animalAnimations;
        private Dictionary<string, List<Movement>> animalMovements;

        private Monster()
        {
            // 동물 애니메이션 데이터 초기화
            animalAnimations = new Dictionary<string, List<string>>()
            {
                { "rabbit", new List<string>
                    {
                        "\n\n /\\_/\\\n ( o.o )\n (\")_(\")",
                        "\n\n /\\_/\\\n ( o.x )\n (\")_(\")",
                        "\n\n /\\_/\\\n ( x.o )\n (\")_(\")"
                    }
                },
                { "cat", new List<string>
                    {
                        "\n\n /\\_/\\\n ( =^.^= )\n (\")_(\")",
                        "\n\n /\\_/\\\n ( =^.o= )\n (\")_(\")",
                        "\n\n /\\_/\\\n ( o^.^= )\n (\")_(\")"
                    }
                },
            };

            // 동물 움직임 데이터 초기화
            animalMovements = new Dictionary<string, List<Movement>>()
            {
                {
                    "rabbit", new List<Movement>
                    {
                        new Movement { Direction = "Right", Steps = 3 },
                        new Movement { Direction = "Left", Steps = 3 }
                    }
                },
                // 추가 동물 움직임 데이터...
            };
        }

        public Dictionary<string, List<string>> GetAnimalAnimations()
        {
            return animalAnimations;
        }

        public Dictionary<string, List<Movement>> GetAnimalMovements()
        {
            return animalMovements;
        }

        public class Movement
        {
            public string Direction { get; set; }
            public int Steps { get; set; }
        }
    }
}
