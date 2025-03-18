public class Prompt()
{
    public List<string> _prompts = new List<string>()
    {
        "What was the most interesting part of your day?",
        "What are you most grateful for today?",
        "What is something you learned recently?",
        "How did you help someone today?",
        "What made you smile today?"
    };

    public string GetRandomPrompt() 
    {
        Random random = new Random();
        //Generating and picking a random element by its index on the _prompts list to get a prompt
        int index = random.Next(_prompts.Count);

        //Getting the random prompt 
         string randomPrompt = _prompts[index];
         return randomPrompt;
        
    }


}