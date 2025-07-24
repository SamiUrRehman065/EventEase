using EventEase.Models;

namespace EventEase.Services
{
    public class MockEventService
    {
        public List<Event> GetAllEvents() => new List<Event>
        {
            new Event { Id = "1", Name = "Tech Innovation Meetup", Date = DateTime.Today.AddDays(5), Location = "Karachi", Description = "Connect with tech enthusiasts and share groundbreaking ideas." },
            new Event { Id = "2", Name = "Creative Design Workshop", Date = DateTime.Today.AddDays(12), Location = "Lahore", Description = "Hands-on design session for budding creatives." },
            new Event { Id = "3", Name = "Startup Pitch Day", Date = DateTime.Today.AddDays(20), Location = "Islamabad", Description = "Watch or participate in pitches by emerging entrepreneurs." },
            new Event { Id = "4", Name = "AI & Data Science Summit", Date = DateTime.Today.AddDays(8), Location = "Karachi", Description = "Explore the future of machine learning and analytics." },
            new Event { Id = "5", Name = "Mobile App Hackathon", Date = DateTime.Today.AddDays(15), Location = "Lahore", Description = "Build mobile solutions under pressure and win prizes." },
            new Event { Id = "6", Name = "Women in Tech Forum", Date = DateTime.Today.AddDays(22), Location = "Islamabad", Description = "Empowering women shaping the future of tech." },
            new Event { Id = "7", Name = "Cloud Dev Conference", Date = DateTime.Today.AddDays(6), Location = "Karachi", Description = "Deep dive into scalable cloud architecture." },
            new Event { Id = "8", Name = "UX/UI Design Jam", Date = DateTime.Today.AddDays(17), Location = "Lahore", Description = "Collaborative prototyping for amazing user experiences." },
            new Event { Id = "9", Name = "Blockchain Expo", Date = DateTime.Today.AddDays(11), Location = "Islamabad", Description = "Demystifying crypto tech and decentralized systems." },
            new Event { Id = "10", Name = "Game Development Bootcamp", Date = DateTime.Today.AddDays(19), Location = "Karachi", Description = "From concept to controller — design your own game." },
            new Event { Id = "11", Name = "Agile Transformation Seminar", Date = DateTime.Today.AddDays(7), Location = "Lahore", Description = "Best practices for building agile organizations." },
            new Event { Id = "12", Name = "Cybersecurity Essentials", Date = DateTime.Today.AddDays(25), Location = "Islamabad", Description = "Protect data and digital lives with real-world strategies." },
            new Event { Id = "13", Name = "GreenTech Startups Panel", Date = DateTime.Today.AddDays(13), Location = "Karachi", Description = "Discuss innovations driving sustainable technology." },
            new Event { Id = "14", Name = "Digital Nomad Gathering", Date = DateTime.Today.AddDays(16), Location = "Lahore", Description = "Learn remote work strategies from thriving freelancers." },
            new Event { Id = "15", Name = "Product Managers Meetup", Date = DateTime.Today.AddDays(9), Location = "Islamabad", Description = "Join the minds behind strategic tech development." },
            new Event { Id = "16", Name = "Open Source Contributor Day", Date = DateTime.Today.AddDays(18), Location = "Karachi", Description = "Get involved in OSS projects and make an impact." },
            new Event { Id = "17", Name = "Hardware Hack & Build", Date = DateTime.Today.AddDays(21), Location = "Lahore", Description = "Arduino, Raspberry Pi, and real-world tinkering." },
            new Event { Id = "18", Name = "Digital Marketing Essentials", Date = DateTime.Today.AddDays(14), Location = "Islamabad", Description = "Master SEO, analytics, and social media strategy." },
            new Event { Id = "19", Name = "Data Visualization Workshop", Date = DateTime.Today.AddDays(23), Location = "Karachi", Description = "Turn complex data into compelling visuals." },
            new Event { Id = "20", Name = "Tech Community Open Mic", Date = DateTime.Today.AddDays(10), Location = "Lahore", Description = "Share stories, rants, and insights with fellow devs." }
        };

        public Event? GetEventById(string id)
        {
            return GetAllEvents().FirstOrDefault(e => e.Id == id);
        }
    }
}