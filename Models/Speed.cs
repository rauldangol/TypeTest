namespace TypeTest.Models
{
    public class Speed
    {
        public string[] SentencesToType { get; set; }
        public string SentenceByUser { get; set; }
        public string TextToType { get; set; }
        public bool Status { get; set; }
        public int WordsPerMinute { get; set; }
        public int Accuracy { get; set; }
        public int TotalCharactersTyped { get; set; }
        public int CorrectlyTypedCharacters { get; set; }
        public DateTime StartTime { get; set; }

        public Speed()
        {
            SentencesToType = new string[]
            {
                "As the sun set over the horizon, casting a warm golden glow across the sky, the weary traveler trudged onward through the desolate wilderness, feeling the weight of his backpack grow heavier with each passing step.",
                "The intricate pattern of the stained-glass window was a testament to the skill and artistry of the craftsmen who had spent countless hours painstakingly piecing together each shard of colorful glass.",
                "The gentle lapping of the waves against the shore provided a soothing soundtrack to the couple's romantic stroll along the moonlit beach.",
                "With a trembling hand, she reached out to grasp the ancient artifact, marveling at its intricate design and the weight of history it carried.",
                "The deafening roar of the waterfall drowned out all other sounds, and as the misty spray drenched her skin and hair, she felt a sense of awe and reverence for the sheer power and beauty of nature.",
                "In the quiet stillness of the early morning, the chirping of the birds and the rustling of the leaves provided a peaceful symphony that awakened the senses and renewed the spirit.",
                "The thick, pungent aroma of the steaming bowl of spicy curry filled the air, making her mouth water as she eagerly reached for a spoon and took her first bite.",
                "The old man sat in his rocking chair on the front porch, his weathered face creased with deep lines of wisdom and experience as he gazed out at the rolling hills in the distance.",
                "The gentle sway of the hammock lulled her into a peaceful slumber, the rustling leaves providing a soothing background soundtrack to the symphony of chirping crickets and hooting owls.",
                "With each brushstroke, the artist poured his soul onto the canvas, creating a masterpiece that captured the essence of his emotions and experiences."

            };
        }
    }
}
