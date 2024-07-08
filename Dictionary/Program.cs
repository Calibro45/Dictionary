namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Partendo da una lista di studenti crea un dictionary
             * che abbia come chiave il nome e come valore una lista 
             * di studenti con lo stesso nome
            */

            var studentList = new List<Student>
            {
                new Student("Andrea", "Rossi"),
                new Student("Andrea", "Verdi"),
                new Student("Pippo", "Pippi"),
                new Student("Pluto", "Pluti"),
                new Student("Topolino", "Topolinis"),
                new Student("Pippo", "De Pippi")
            };

            var studentDictionary = new Dictionary<string, List<Student>>();

            foreach (var s in studentList)
            {
                if (!studentDictionary.ContainsKey(s.Name))
                {
                    studentDictionary.Add(s.Name, new List<Student> { s });
                }
                else
                    studentDictionary[s.Name].Add(s);
            }

            foreach (var v in studentDictionary.Values)
            {
                v.ForEach( s => 
                    Console.WriteLine($"Nome: {s.Name}, Cognome: {s.Surname}")
                    );
            }
        }
    }
}
