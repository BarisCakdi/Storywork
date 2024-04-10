namespace Storywork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("World of Warcraft: Kayıp Hazine!");
            Console.Write("Taraf seçimi = Horde(H)/Alliance(A):" );
            string answer = Console.ReadLine();
            if (answer == "h" || answer == "H")
            {
                //Horde alanı
                Console.Clear();
                Console.WriteLine("Artık Horde için kan dökeceksin!");
                Console.WriteLine("FOR THE HORDE!!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Şimdi savaş çadırından çıktın ve bir yol ayrımına geldin");
                Console.Write("Kuytu Orman(O)/Derin Vadi(V): ");
                string O = Console.ReadLine();
                if (O == "O" || O == "o" )
                {
                    //kuytu orman
                    Console.Clear();
                    Console.WriteLine("Kuytu ormanda ilerlerken karşıda büyük bir örümcek çıktı! Saldır(s)/Kaç(k)");
                    string answer1 = Console.ReadLine();
                    if (answer1 == "s" || answer1 == "S")
                    {
                        Console.Clear();
                        Console.WriteLine("Örümceği alt edip değerli hazinesine ulaştın, artık daha güçlüsün!");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Kuytu ormanı geçmeyi başardın tebrikler savaşçı");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Artık 'Warsong Gulch' bölgesine ulaştın ve dostlarına yardım etmeye hazırsın. Bol şans! ");
                        Console.WriteLine("FOR THE HORDE!!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Kaçmaya çalışırken örümceklerin ağına yakalanıp yem oldun!");
                        Console.WriteLine("Tekrar başlamak için yeniden giriş yapın!");
                    }
                }
                else
                {
                    //vadi alanı
                    Console.Clear();
                    Console.WriteLine("Vadiden geçerken 'Alliance' saldırısına uğradın");
                    Console.ReadLine() ;
                    Console.Clear();
                    Console.WriteLine("Horde yardımına koştu ve düşmanı mağlup etmeyi başardınız. Destek birlik ile devam(D)/Tek başına devam(T)?");
                    string answer2 = Console.ReadLine();
                    if(answer2 == "D" || answer2 == "d")
                    {
                        Console.Clear();
                        Console.WriteLine("Kalabalık halde ilerleyişiniz diğer 'Alliance' birliklerinin dikkatini çekti, kalabalık bir saldırı alıp bütün grup katledildi");
                        Console.WriteLine("Tekrar başlamak için yeniden giriş yapın!");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Daha dikkatli bir şekilde derin vadide ilerleyip değerli zırh ve kılıç buldun");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Artık 'Warsong Gulch' bölgesine ulaştın ve dostlarına yardım etmeye hazırsın. Bol şans! ");
                        Console.WriteLine("FOR THE HORDE!!");


                    }

                }
            }
            else
            {
                //"alliance alanı"
                Console.Clear();
                Console.WriteLine("Artık 'Alliance' için savaşıcaksın");
                Console.WriteLine("FOR THE ALLİANCE!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Alliance'ların büyük 'Stromwind' şehrinden çıkış yaptın. Hangi tarafa? 'Westfall(W)/Burning Steppes(B) ");
                string answer3 = Console.ReadLine();
                if (answer3 == "W" || answer3 == "w") 
                {
                    //Westfall
                    Console.Clear();
                    Console.WriteLine("Westfall yönüne ilerlerken harabelerin orada alliance askeri ile haydutlar arasındaki çatışmaya denk geldin.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Hemen alliance yardımına koştun ve birlikte haydutları yok ettiniz. Alliance kaptanı kendilerine katılma teklifinde bulundu. Kabul(K)/Red(R)");
                    string answer4 = Console.ReadLine();
                    if(answer4 == "K" || answer4 == "k")
                        {
                        Console.Clear();
                        Console.WriteLine("Kaptan hemen üzerine daha iyi zırh giydirdi...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Artık düzenli bir birlikte olduğun için 'Horde' ile daha iyi savaşmaya başladınız ve dağınık dolaşan hordeleri yok ediyorsunuz!");
                        Console.WriteLine("FOR THE ALLİANCE!");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Kaptanın teklifini reddetip tek başına ilerlemeye başladın...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("'Westfall' bölgesinde ilerlerken pusu kurmuş Horde tarafından saldıraya uğrayıp katlediliyorsun");
                        Console.WriteLine("Tekrar başlamak için yeniden giriş yapın!");

                    }

                }
                else
                {
                    //burningsteppes
                    Console.Clear();
                    Console.WriteLine("Kavrulmuş toprak üzerinde yürürken harabeye benzeyen bir taverna görüp birşeyler içmek için içeriye giriyorsun");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Büyük bir bardak bira, yanında yarım köy ekmeği, onun yanına bol yağlı bir peynir ile yemeğini yerken...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Yan masada haydutların tavernayı soymak için plan yaptıklarını duyuyorsun. Müdahale et(S)/Duymamazlıktan gel(K)");
                    string answer5 = Console.ReadLine();
                    if(answer5 == "s" || answer5 == "S")
                    {
                        Console.Clear();
                        Console.WriteLine("Haydutlara hamle yaptın ama sayıları fazla olduğu için dar alanda seni öldürdüler!");
                        Console.WriteLine("Tekrar başlamak için yeniden giriş yapın!");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hemen dışarıya çıktın ve şans eseri oradan geçmekte olan 'Alliance' birliği görüp durumu bildirdin...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Birlikte içeriye dalıp bütün haydutları katlettiniz ve bunun karşılığı tavernanın sahibi atalarından kalma muazzam bir zırh hediye etti sana..");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Gelen birlikle birlikte 'Warsong Gulch' muhabere alanına gidip cesurca Horde kuvvetlerine karşı savaş vermeye başladın.");
                        Console.WriteLine("FOR THE ALLİANCE!");

                    }
                }
            }

          

        }
    }
}
