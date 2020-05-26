namespace dmc_tasks.Entities
{
    public class SupportAssistant
    {
        public int AssistantId { get; set; }
        public Employee Assistant { get; set; }
        public int SupportRequestId { get; set; }
        public SupportRequest SupportRequest { get; set; }

        public SupportAssistant() { }
        public SupportAssistant(int req, int assistant)
        {
            SupportRequestId = req;
            AssistantId = assistant;
        }
    }
}
