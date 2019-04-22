using System.Collections.Generic;

namespace TestAspNet.Models
{
    public static class Repository
    {
        private static List<QuestResponse> _responses = new List<QuestResponse>();

        public static IEnumerable<QuestResponse> Responses => _responses;

        public static void AddResponse(QuestResponse response) => _responses.Add(response);
    }
}
