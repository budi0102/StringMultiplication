using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComputation = 4;
            Thread[] T = new Thread[numberOfComputation];
            T[0] = new Thread(() => ComputeList(ref Data)); 
            T[0].Name = "Compute List of Strings 1";
            T[1] = new Thread(() => ComputeList(ref Data2));
            T[1].Name = "Compute List of Strings 2";
            T[2] = new Thread(() => ComputeArray(ref Data3));
            T[2].Name = "Compute Array of Strings 3";
            T[3] = new Thread(() => ComputeArrayMultiTask(Data3));
            T[3].Name = "Compute Array of Strings with multitask";

            for (int i = numberOfComputation-1; i >= 0;i-- )
            {
                T[i].Start();
            }

            Thread.Sleep(4000);
            //for (int i = numberOfComputation-1; i >= 0; i--)
            //{  
            //    T[i].Join();
            //}
            //Console.ReadKey();
        }

        public static List<string> Data = new List<string>(new string[] { "cat", "dog", "meow", "bow", "elephant", "monkey", "human", "xxx", "funky" });
        public static List<string> Data2 = new List<string> { "soda", "sky", "stone", "huge", "sound", "grass", "casino", "media", "push", "step", "event", "cyber", "blog", "modern", "water", "strength", "wallpaper", "wine", "hand", "drink", "funky", "exact", "landscape", "toy", "president", "minute", "believe", "wish", "favor", "sin", "about", "take", "booth", "chocolate", "pink", "fact", "real", "terrorism", "win", "eat", "interest", "course", "gun", "illusion", "gift", "phone", "lead", "because", "oil", "might", "platform", "lottery", "angel", "against", "true", "ceremony", "computer", "exterior", "future", "choice", "customer", "smoke", "go", "object", "kiss", "wonder", "handmade", "random", "peace", "oxygen", "please", "couple", "destination", "first", "color", "science", "relaxation", "erotic", "baby", "repeat", "teen", "name", "innocence", "picture", "flat", "offer", "puppy", "possible", "power", "tribute", "life", "hero", "pet", "difficult", "finger", "outdoors", "desert", "help", "never", "instrument", "group", "memory", "solitude", "remember", "agree", "barbary", "bonding", "apprentice", "deep", "ruin", "radio", "symbol", "straight", "band", "news", "satisfaction", "famous", "lips", "art", "fair", "plant", "nothing", "section", "size", "nostalgia", "dear", "money", "politic", "TV", "article", "pollution", "perfume", "security", "accountant", "love", "lust", "gender", "carry", "daughter", "pretty", "calm", "effect", "label", "chance", "alone", "lady", "hit", "buy", "tradition", "tribune", "finance", "government", "dance", "bike", "edge", "chick", "auction", "think", "detail", "police", "herb", "contract", "sofa", "center", "create", "body", "flower", "provide", "fish", "cat", "animal", "blood", "map", "defeat", "extravaganza", "always", "resource", "press", "ray", "robe", "background", "result", "white", "direction", "minority", "supermarket", "basket", "thousand", "capitalism", "clean", "guide", "college", "legal", "architecture", "spider", "passion", "seat", "mood", "breast", "club", "intense", "church", "care", "beautiful", "big", "international", "bazaar", "metal", "desire", "departure", "baseball", "surf", "trade", "soldier", "fresh", "tool", "roulette", "shadow", "lawyer", "java", "work", "girl", "track", "phenomena", "drop", "figure", "print", "halloween", "save", "experience", "finish", "poor", "final", "saint", "paper", "curiosity", "confidence", "groom", "happen", "independence", "bone", "luxury", "cheek", "range", "journey", "danger", "old", "palm", "journal", "concept", "glamour", "rally", "hi-tech", "jazz", "suburb", "podcast", "lesbian", "allow", "kill", "vote", "melody", "petal", "exercise", "have", "guess", "resort", "border", "pure", "today", "together", "cream", "short", "great", "climate", "PC", "coffee", "ringtone", "humor", "misc", "spend", "woman", "sophisticated", "tower", "call", "turn", "lyric", "listen", "song", "positive", "rich", "buddy", "limit", "conflict", "palace", "close", "wear", "energy", "suggest", "sugar", "captive", "quick", "attractive", "basic", "research", "store", "continent", "industry", "cold", "anger", "end", "drugs", "expand", "annual", "stress", "allergy", "game", "marriage", "feeling", "comic", "company", "visit", "earth", "learn", "holiday", "jump", "category", "born", "romance", "park", "digital", "light", "tribal", "sign", "diet", "subject", "age", "heart", "doctor", "noise", "city", "community", "begin", "update", "pay", "compare", "anime", "product", "tell", "shop", "mask", "bride", "wild", "notice", "smile", "motion", "wait", "mile", "idea", "sport", "dictionary", "mountain", "do", "habitat", "bread", "past", "rise", "hear", "frozen", "yes", "recipe", "pride", "road", "town", "entertainment", "addict", "exit", "shirt", "temperature", "job", "risk", "precision", "fitness", "weather", "mother", "skirt", "taxes", "museum", "father", "football", "tiny", "correct", "piece", "fame", "demonstration", "laptop", "wife", "CD", "wireless", "punishment", "musing", "reward", "star", "VOIP", "disco", "house", "communication", "doll", "majestic", "general", "shoe", "student", "photo", "path", "target", "share", "action", "lonely", "aspiration", "silence", "apartment", "must", "internet", "attention", "say", "force", "position", "environment", "directory", "order", "prove", "luck", "website", "commerce", "spice", "sister", "fun", "royalty", "enemy", "muscle", "style", "lounge", "clothe", "download", "day", "emergency", "one", "will", "treasury", "respect", "story", "trouble", "full", "noon", "break", "mate", "engine", "justice", "eye", "forward", "poem", "bank", "coast", "excite", "declaration", "film", "screensaver", "discovery", "present", "laugh", "empty", "portable", "sex", "stop", "off", "bottom", "business", "play", "climb", "adult", "discuss", "fruit", "conversation", "adorable", "solver", "trip", "beverage", "enter", "mind", "send", "elegance", "circus", "hotel", "root", "court", "murmur", "dragon", "pub", "food", "imagine", "hair", "cash", "credit", "grow", "gamble", "quote", "school", "master", "year", "affection", "flame", "degree", "match", "element", "funny", "question", "history", "queen", "campus", "fantasy", "speech", "mix", "tear", "time", "brunette", "stairway", "party", "marketing", "original", "copy", "instant", "translation", "cloud", "expect", "actor", "sea", "thanksgiving", "message", "arrive", "dress", "ask", "practice", "miracle", "exam", "ticket", "entrance", "sleep", "simple", "black", "appear", "deal", "courage", "rental", "earring", "retail", "butt", "sun", "curve", "organ", "library", "portrait", "warm", "emotion", "egg", "hiphop", "DIY", "newlywed", "jeans", "indoor", "birthday", "long", "install", "sensual", "cool", "adolescent", "patriot", "skin", "protest", "fight", "card", "scale", "come", "rare", "point", "interior", "arrest", "greeting", "family", "calorie", "alcohol", "cemetery", "exotic", "bill", "phrase", "sad", "blackjack", "lost", "race", "tropic", "tan", "slim", "delicious", "need", "leg", "diversity", "system", "archive", "model", "christmas", "mouth", "young", "flag", "support", "relative", "magic", "change", "reserve", "scream", "tip", "gas", "society", "toe", "look", "orchestra", "goddess", "hobby", "world", "design", "gorgeous", "broadband", "air", "blonde", "language", "number", "heat", "clear", "nobody", "athlete", "garden", "joy", "topless", "face", "attitude", "joke", "search", "fashion", "hug", "stationary", "boat", "dollar", "mini", "street", "DVD", "rescue", "success", "best", "bath", "feet", "makeup", "teach", "single", "develop", "bikini", "fireworks", "mail", "restaurant", "paradise", "relief", "leave", "office", "smooth", "make", "claim", "fix", "private", "base", "bell", "smell", "land", "generation", "mob", "depression", "silhouette", "liberation", "cartoon", "quiet", "commute", "heavy", "move", "relationship", "expression", "desktop", "fat", "rose", "blow", "ship", "cost", "concert", "spray", "cosmetic", "homosexuality", "medecine", "summer", "friend", "democracy", "parent", "brainstorm", "post", "taxi", "board", "depend", "motor", "find", "camera", "strange", "bright", "rule", "out", "mystery", "pupil", "activist", "complex", "female", "ocean", "dog", "cry", "solidarity", "character", "loan", "raise", "different", "blur", "shine", "sword", "book", "heroic", "thick", "health", "audio", "speed", "carnival", "naked", "shape", "skill", "pop", "magazine", "dirt", "cellphone", "dark", "fear", "nude", "people", "despair", "competition", "brother", "enforcement", "local", "consider", "sympathy", "century", "consumer", "soccer", "stage", "gateway", "fragance", "slow", "software", "mobile", "happy", "answer", "mirror", "record", "problem", "thin", "gay", "forest", "afraid", "know", "nation", "army", "drive", "meet", "review", "advertising", "example", "frame", "cycle", "behind", "hour", "process", "sail", "male", "area", "compassion", "run", "formation", "stick", "graduate", "pier", "pool", "sell", "million", "leisure", "stay", "ecology", "clock", "apple", "concentration", "flirt", "build", "crime", "free", "like", "golf", "weight", "place", "innovation", "island", "education", "artist", "beach", "cute", "public", "burn", "philosophy", "endurance", "observe", "AIDS", "culture", "activity", "explode", "manual", "clown", "sensation", "acrobat", "priceless", "supreme", "war", "temptation", "bad", "beat", "branch", "view", "gold", "wide", "season", "join", "hope", "seduce", "safe", "score", "motivation", "high", "space", "maturity", "moon", "rain", "trap", "bar", "forever", "babe", "value", "arrow", "cruise", "bed", "planet", "both", "identity", "ice", "reply", "movie", "spam", "stability", "overseas", "surprise", "advice", "accessory", "human", "home", "strong", "dawn", "device", "music", "hardware", "good", "glad", "boy", "laundry", "eternity", "note", "travel", "prepare", "email", "cuisine", "hurricane", "honor", "mortgage", "chest", "iron", "guitar", "cook", "celebration", "bizarre", "hot", "special", "gadget", "panties", "online", "logo", "sharp", "machine", "fly", "spiritual", "red", "poker", "decoration", "subway", "start", "theater", "silver", "scenic", "show", "follow", "lake", "military", "men", "nightlife", "busy", "stuff", "chief", "open", "dream", "television", "costume", "spectacular", "lingerie", "next", "religion", "husband", "well", "reason", "obituary", "video", "ready", "tourism", "glass", "mentor", "nail", "MP3", "select", "cinema", "wrong", "fast", "furniture", "survival", "quality", "major", "loud", "comfort", "cowboy", "case", "steam", "splash", "car", "gossip", "kid", "dead", "crowd", "graphic", "beast", "talk", "traffic", "neon", "barefoot", "grocery", "optimism", "destiny", "nature", "king", "tattoo", "flash", "jewelry", "thong", "spot", "main", "chat", "complete", "now", "jackpot", "dry", "rainbow", "aggression", "senior", "connect", "aim", "decide", "electronic", "aviation", "technology", "reach", "thing" };
        public static string[] Data3 = { "soda", "sky", "stone", "huge", "sound", "grass", "casino", "media", "push", "step", "event", "cyber", "blog", "modern", "water", "strength", "wallpaper", "wine", "hand", "drink", "funky", "exact", "landscape", "toy", "president", "minute", "believe", "wish", "favor", "sin", "about", "take", "booth", "chocolate", "pink", "fact", "real", "terrorism", "win", "eat", "interest", "course", "gun", "illusion", "gift", "phone", "lead", "because", "oil", "might", "platform", "lottery", "angel", "against", "true", "ceremony", "computer", "exterior", "future", "choice", "customer", "smoke", "go", "object", "kiss", "wonder", "handmade", "random", "peace", "oxygen", "please", "couple", "destination", "first", "color", "science", "relaxation", "erotic", "baby", "repeat", "teen", "name", "innocence", "picture", "flat", "offer", "puppy", "possible", "power", "tribute", "life", "hero", "pet", "difficult", "finger", "outdoors", "desert", "help", "never", "instrument", "group", "memory", "solitude", "remember", "agree", "barbary", "bonding", "apprentice", "deep", "ruin", "radio", "symbol", "straight", "band", "news", "satisfaction", "famous", "lips", "art", "fair", "plant", "nothing", "section", "size", "nostalgia", "dear", "money", "politic", "TV", "article", "pollution", "perfume", "security", "accountant", "love", "lust", "gender", "carry", "daughter", "pretty", "calm", "effect", "label", "chance", "alone", "lady", "hit", "buy", "tradition", "tribune", "finance", "government", "dance", "bike", "edge", "chick", "auction", "think", "detail", "police", "herb", "contract", "sofa", "center", "create", "body", "flower", "provide", "fish", "cat", "animal", "blood", "map", "defeat", "extravaganza", "always", "resource", "press", "ray", "robe", "background", "result", "white", "direction", "minority", "supermarket", "basket", "thousand", "capitalism", "clean", "guide", "college", "legal", "architecture", "spider", "passion", "seat", "mood", "breast", "club", "intense", "church", "care", "beautiful", "big", "international", "bazaar", "metal", "desire", "departure", "baseball", "surf", "trade", "soldier", "fresh", "tool", "roulette", "shadow", "lawyer", "java", "work", "girl", "track", "phenomena", "drop", "figure", "print", "halloween", "save", "experience", "finish", "poor", "final", "saint", "paper", "curiosity", "confidence", "groom", "happen", "independence", "bone", "luxury", "cheek", "range", "journey", "danger", "old", "palm", "journal", "concept", "glamour", "rally", "hi-tech", "jazz", "suburb", "podcast", "lesbian", "allow", "kill", "vote", "melody", "petal", "exercise", "have", "guess", "resort", "border", "pure", "today", "together", "cream", "short", "great", "climate", "PC", "coffee", "ringtone", "humor", "misc", "spend", "woman", "sophisticated", "tower", "call", "turn", "lyric", "listen", "song", "positive", "rich", "buddy", "limit", "conflict", "palace", "close", "wear", "energy", "suggest", "sugar", "captive", "quick", "attractive", "basic", "research", "store", "continent", "industry", "cold", "anger", "end", "drugs", "expand", "annual", "stress", "allergy", "game", "marriage", "feeling", "comic", "company", "visit", "earth", "learn", "holiday", "jump", "category", "born", "romance", "park", "digital", "light", "tribal", "sign", "diet", "subject", "age", "heart", "doctor", "noise", "city", "community", "begin", "update", "pay", "compare", "anime", "product", "tell", "shop", "mask", "bride", "wild", "notice", "smile", "motion", "wait", "mile", "idea", "sport", "dictionary", "mountain", "do", "habitat", "bread", "past", "rise", "hear", "frozen", "yes", "recipe", "pride", "road", "town", "entertainment", "addict", "exit", "shirt", "temperature", "job", "risk", "precision", "fitness", "weather", "mother", "skirt", "taxes", "museum", "father", "football", "tiny", "correct", "piece", "fame", "demonstration", "laptop", "wife", "CD", "wireless", "punishment", "musing", "reward", "star", "VOIP", "disco", "house", "communication", "doll", "majestic", "general", "shoe", "student", "photo", "path", "target", "share", "action", "lonely", "aspiration", "silence", "apartment", "must", "internet", "attention", "say", "force", "position", "environment", "directory", "order", "prove", "luck", "website", "commerce", "spice", "sister", "fun", "royalty", "enemy", "muscle", "style", "lounge", "clothe", "download", "day", "emergency", "one", "will", "treasury", "respect", "story", "trouble", "full", "noon", "break", "mate", "engine", "justice", "eye", "forward", "poem", "bank", "coast", "excite", "declaration", "film", "screensaver", "discovery", "present", "laugh", "empty", "portable", "sex", "stop", "off", "bottom", "business", "play", "climb", "adult", "discuss", "fruit", "conversation", "adorable", "solver", "trip", "beverage", "enter", "mind", "send", "elegance", "circus", "hotel", "root", "court", "murmur", "dragon", "pub", "food", "imagine", "hair", "cash", "credit", "grow", "gamble", "quote", "school", "master", "year", "affection", "flame", "degree", "match", "element", "funny", "question", "history", "queen", "campus", "fantasy", "speech", "mix", "tear", "time", "brunette", "stairway", "party", "marketing", "original", "copy", "instant", "translation", "cloud", "expect", "actor", "sea", "thanksgiving", "message", "arrive", "dress", "ask", "practice", "miracle", "exam", "ticket", "entrance", "sleep", "simple", "black", "appear", "deal", "courage", "rental", "earring", "retail", "butt", "sun", "curve", "organ", "library", "portrait", "warm", "emotion", "egg", "hiphop", "DIY", "newlywed", "jeans", "indoor", "birthday", "long", "install", "sensual", "cool", "adolescent", "patriot", "skin", "protest", "fight", "card", "scale", "come", "rare", "point", "interior", "arrest", "greeting", "family", "calorie", "alcohol", "cemetery", "exotic", "bill", "phrase", "sad", "blackjack", "lost", "race", "tropic", "tan", "slim", "delicious", "need", "leg", "diversity", "system", "archive", "model", "christmas", "mouth", "young", "flag", "support", "relative", "magic", "change", "reserve", "scream", "tip", "gas", "society", "toe", "look", "orchestra", "goddess", "hobby", "world", "design", "gorgeous", "broadband", "air", "blonde", "language", "number", "heat", "clear", "nobody", "athlete", "garden", "joy", "topless", "face", "attitude", "joke", "search", "fashion", "hug", "stationary", "boat", "dollar", "mini", "street", "DVD", "rescue", "success", "best", "bath", "feet", "makeup", "teach", "single", "develop", "bikini", "fireworks", "mail", "restaurant", "paradise", "relief", "leave", "office", "smooth", "make", "claim", "fix", "private", "base", "bell", "smell", "land", "generation", "mob", "depression", "silhouette", "liberation", "cartoon", "quiet", "commute", "heavy", "move", "relationship", "expression", "desktop", "fat", "rose", "blow", "ship", "cost", "concert", "spray", "cosmetic", "homosexuality", "medecine", "summer", "friend", "democracy", "parent", "brainstorm", "post", "taxi", "board", "depend", "motor", "find", "camera", "strange", "bright", "rule", "out", "mystery", "pupil", "activist", "complex", "female", "ocean", "dog", "cry", "solidarity", "character", "loan", "raise", "different", "blur", "shine", "sword", "book", "heroic", "thick", "health", "audio", "speed", "carnival", "naked", "shape", "skill", "pop", "magazine", "dirt", "cellphone", "dark", "fear", "nude", "people", "despair", "competition", "brother", "enforcement", "local", "consider", "sympathy", "century", "consumer", "soccer", "stage", "gateway", "fragance", "slow", "software", "mobile", "happy", "answer", "mirror", "record", "problem", "thin", "gay", "forest", "afraid", "know", "nation", "army", "drive", "meet", "review", "advertising", "example", "frame", "cycle", "behind", "hour", "process", "sail", "male", "area", "compassion", "run", "formation", "stick", "graduate", "pier", "pool", "sell", "million", "leisure", "stay", "ecology", "clock", "apple", "concentration", "flirt", "build", "crime", "free", "like", "golf", "weight", "place", "innovation", "island", "education", "artist", "beach", "cute", "public", "burn", "philosophy", "endurance", "observe", "AIDS", "culture", "activity", "explode", "manual", "clown", "sensation", "acrobat", "priceless", "supreme", "war", "temptation", "bad", "beat", "branch", "view", "gold", "wide", "season", "join", "hope", "seduce", "safe", "score", "motivation", "high", "space", "maturity", "moon", "rain", "trap", "bar", "forever", "babe", "value", "arrow", "cruise", "bed", "planet", "both", "identity", "ice", "reply", "movie", "spam", "stability", "overseas", "surprise", "advice", "accessory", "human", "home", "strong", "dawn", "device", "music", "hardware", "good", "glad", "boy", "laundry", "eternity", "note", "travel", "prepare", "email", "cuisine", "hurricane", "honor", "mortgage", "chest", "iron", "guitar", "cook", "celebration", "bizarre", "hot", "special", "gadget", "panties", "online", "logo", "sharp", "machine", "fly", "spiritual", "red", "poker", "decoration", "subway", "start", "theater", "silver", "scenic", "show", "follow", "lake", "military", "men", "nightlife", "busy", "stuff", "chief", "open", "dream", "television", "costume", "spectacular", "lingerie", "next", "religion", "husband", "well", "reason", "obituary", "video", "ready", "tourism", "glass", "mentor", "nail", "MP3", "select", "cinema", "wrong", "fast", "furniture", "survival", "quality", "major", "loud", "comfort", "cowboy", "case", "steam", "splash", "car", "gossip", "kid", "dead", "crowd", "graphic", "beast", "talk", "traffic", "neon", "barefoot", "grocery", "optimism", "destiny", "nature", "king", "tattoo", "flash", "jewelry", "thong", "spot", "main", "chat", "complete", "now", "jackpot", "dry", "rainbow", "aggression", "senior", "connect", "aim", "decide", "electronic", "aviation", "technology", "reach", "thing" };
        //public static volatile StringBuilder sb = new StringBuilder();

        /// <summary>
        /// Computing multiplication through all of possible pair strings in the list
        /// Processing array of strings is faster than list of strings, because array is more primitive.
        /// </summary>
        /// <param name="strlist">array of strings</param>
        public static void ComputeArray(ref string[] strlist)
        {
            DateTime start = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            if (strlist == null || strlist.Length <= 0)
            {
                return;
            }

            int result = 0;

            for (int i = 0; i < strlist.Length; i++)
            {
                for (int j = i + 1; j < strlist.Length; j++)
                {
                    result = Compute(strlist[i], strlist[j]);
                    sb.AppendFormat("{0}:<{1}> * {2}:<{3}> = {4}{5}", i, strlist[i], j, strlist[j], result, Environment.NewLine);
                }
            }

            TimeSpan ts = DateTime.Now - start;
            //Console.WriteLine(sb);
            Console.WriteLine("Current thread is {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Timespan is {0}ms", ts.TotalMilliseconds);
        }

        /// <summary>
        /// Computing multiplication through all of possible pair strings in the list
        /// Processing array of strings is faster than list of strings, because array is more primitive.
        /// This is slowest, due to:
        /// 1. Processing List (vs. processing array which has less header)
        /// 2. Outputting to Console every result (vs. building string and print out later time)
        /// </summary>
        /// <param name="strlist">list of strings</param>
        public static void ComputeList(ref List<string> strlist)
        {
            DateTime start = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            if (strlist == null || strlist.Count <= 0)
            {
                return;
            }

            int result = 0;
            for (int i = 0; i < strlist.Count - 1; i++)
            {
                for (int j = i + 1; j < strlist.Count; j++)
                {
                    result = Compute(strlist[i], strlist[j]);
                    //Console.WriteLine("{0}:<{1}> * {2}:<{3}> = {4}", i, strlist[i], j, strlist[j], result);
                    sb.AppendFormat("{0}:<{1}> * {2}:<{3}> = {4}{5}", i, strlist[i], j, strlist[j], result, Environment.NewLine);
                }
            }

            TimeSpan ts = DateTime.Now - start;
            //Console.WriteLine(sb);
            Console.WriteLine("Current thread is {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Timespan is {0}ms", ts.TotalMilliseconds);
        }

        /// <summary>
        /// Singleton of string length multiplication
        /// </summary>
        /// <param name="a">string 1</param>
        /// <param name="b">string 2</param>
        /// <returns></returns>
        private static int Compute(string a, string b)
        {
            if (DoesCollide(ref a, ref b))
            {
                return 0;
            }

            return a.Length * b.Length;
        }

        /// <summary>
        /// Method to detect collision
        /// Hashtable benefits than using array of bool:
        /// 1. able to store wchar (but unfortunately this code only accepts char)
        /// 2. creates smaller table size (size of length of the string) compared to bool array (256 bytes at least)
        /// 
        /// Bad thing from hashtable
        /// 1. Slower because any hashtable method requires some constant work more.
        /// </summary>
        /// <param name="a">string 1</param>
        /// <param name="b">string 2</param>
        /// <returns></returns>
        private static bool DoesCollide(ref string a, ref string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return false;
            }

            Hashtable ht = new Hashtable();

            foreach (char c in a)
            {
                if (!ht.ContainsKey(c))
                    ht.Add(c, true);

                // the methods below takes longer time.
                //try
                //{
                //    ht.Add(c, true);
                //}
                //catch (System.ArgumentException)
                //{
                // ignore the exception thrown if you are adding same key twice
                //}

            }
            foreach (char c in b)
            {
                if (ht.ContainsKey(c))
                    return true;

                // the methods below takes longer time.
                //try
                //{
                //    ht.Add(c, true);
                //}
                //catch (System.ArgumentException)
                //{
                // collision detected
                //    return true;
                //}
            }

            return false;
        }

        #region Multi Task/ Threading
        /// <summary>
        /// Multitask/threading method
        /// </summary>
        /// <param name="strlist">array of strings</param>
        public static void ComputeArrayMultiTask(string[] strlist)
        {
            DateTime start = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            if (strlist == null || strlist.Length <= 0)
                return;
            Task<bool> task = null;
            //int result = 0;
            for (int i = 0; i < strlist.Length; i++)
            {
                for (int j = i + 1; j < strlist.Length; j++)
                {
                    int x = i;
                    int y = j;
                    task = Task.Factory.StartNew(() => ComputeMultiTask(strlist[x], strlist[y], ref sb));
                }
            }

            TimeSpan ts = DateTime.Now - start;
            bool b = task.Result;
            //Console.WriteLine(sb);
            Console.WriteLine("Current thread is {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Timespan is {0} ms", ts.TotalMilliseconds);
        }

        /// <summary>
        /// Singleton of string length multiplication
        /// </summary>
        /// <param name="a">string 1</param>
        /// <param name="b">string 2</param>
        /// <returns></returns>
        private static bool ComputeMultiTask(string a, string b, ref StringBuilder sb)
        {
            if (DoesCollide(ref a, ref b))
            {
                lock (sb)
                {
                    sb.AppendFormat("<{0}> * <{1}> = {2}{3}", a, b, 0, Environment.NewLine);
                }
            }
            else
            {
                lock (sb)
                {
                    sb.AppendFormat("<{0}> * <{1}> = {2}{3}", a, b, a.Length * b.Length, Environment.NewLine);
                }
            }

            return true;
        }
        #endregion
    }
}
