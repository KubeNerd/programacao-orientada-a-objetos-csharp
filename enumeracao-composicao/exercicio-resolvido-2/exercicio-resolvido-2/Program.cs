using exercicio_resolvido_2.Entities;

namespace exercicio_resolvido_2 {
    class Program
    {
        public static void Main(string[] args) {
        
            Comment c1 = new Comment("Have a nice day!");
            Comment c2 = new Comment("Ok, it's so cool");
            Comment c3 = new Comment("Good Nigth!");
            Post p1 = new Post(
                DateTime.Parse("23/09/2024 17:55:05:44"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderful country!",
                12


            );

            p1.AddComment(c3);
        
        }
    }

}