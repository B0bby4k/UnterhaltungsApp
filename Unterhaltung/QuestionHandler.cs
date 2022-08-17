using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Unterhaltung
{
    public partial class QuestionHandler
    {
        static string[] uns = {
                "Wie beschreibst du unsere Beziehung?",
                "Was würdest du gerne mit mir zusammen erleben?",
                "Bei welchen Schwierigkeiten fragst du mich gerne um Rat?",
                "Was wolltest du mir schon immer mal sagen?",
                "Worüber sprichst du ungern mit mir?",
                "Inwiefern bereichere ich dein Leben?",
                "Was machst du ungern mit mir zusammen?",
                "Wofür können wir uns gemeinsam begeistern?",
                "Wie beschreibst du mich anderen gegenüber?",
                "Was nervt dich an unserer Beziehung?",
                "Was wünscht du dir für unsere Zukunft?",
                "Welche Rolle spiele ich in deinem Leben?",
                "Was belastet unsere Beziehung?",
                "Welche unserer gemeinsamen Erlebnisse sind dir besonders in Erinnerung geblieben?",
                "Welche Rolle nehmen wir beide in unserer Beziehung zueinander ein?",
                "Was ist die größte Stärke und Schwäche unserer Beziehung?",
                "Was macht unser Verhältnis besonders?",
                "Was ist dir von unserer ersten Begegnung in Erinnerung geblieben?",
                "Worüber sprichst du gern mit mir?",
                "Inwiefern inspiriere ich dich?",
                "Gibt es etwas, worum du mich beneidest?",
                "Mit welchen meiner Verhaltensweisen verletzte ich dich?",
                "Was hast du von mir gelernt?",
                "Wobei könnte ich dir mehr helfen?",
                "Welchen Titel würdest du diesem Kapitel unserer Beziehung geben?",
                "Welche Frage würdest du mir gerne stellen?",
                "Wie erlebst du unsere Kommunikation?",
                "Inwiefern hat sich unsere Beziehung verändert?",
                "Wann haben wir am meisten Spaß zusammen?",
                "Was könnte ich öfter für dich tun?",
                "Welches Gefühl hast du wenn wir Zeit miteinander verbringen?",
                "Wie fühlst du dich wenn wir uns nicht sehen?"};

        static List<string> fragenUns = new List<string>(uns);

        static string[] mich = {
                "Welche Person würdest du mir gerne vorstellen?",
                "Was kann ich besonders gut?",
                "Welches Buch empfiehlst du mir am wärmsten und warum?",
                "Was schätzt du am meisten an mir?",
                "Was denkst du über meine Freundschaft?",
                "Was scheine ich selbst nicht über mich zu realisieren?",
                "Wann wirke ich am glücklichsten?",
                "An welcher meiner Eigenschaften könnte ich arbeiten?",
                "Welche meiner Entscheidungen bewunderst du?",
                "Was, denkst du, würde mir gut tun?",
                "Welchen Stellenwert hat Familie in meinem Leben?",
                "Was sagt mein Kleidungsstil über mich aus?",
                "Welche Adjektive beschreiben meinen Charakter am besten?",
                "Was findest du äußerlich an mir besonders schön?",
                "Was hebt mich von anderen ab?",
                "Welchen Eindruck mache ich zurzeit auf dich?",
                "Welche Rolle spielt Geld in meinem Leben?",
                "Wie frei bin ich? Inwiefern bin ich in meiner Freiheit eingeschränkt?",
                "Worauf kann ich stolz sein?",
                "Mit welchen Themen setze ich mich ungern auseinander?",
                "Wovor, glaubst du, habe ich Angst?",
                "Wie, denkst du, war meine Kindheit?",
                "Welche Rolle spielt mein Beruf in meinem Leben?",
                "Welche Erlebnisse haben mich am meisten geprägt?",
                "Welchen Titel würdest du meinem aktuellen Lebensabschnitt geben?",
                "Inwiefern beeinflusst mich meine Erziehung?",
                "Was wünscht du mir für die Zukunft?",
                "Welche Entscheidung hätte ich aus deiner Sicht anders treffen sollen?",
                "Was nervt dich an mir?",
                "Was liebst du an mir?",
                "Inwiefern habe ich mich in den letzten Jahren verändert?"};

        static List<string> fragenMich = new List<string>(uns);

        static string[] dich = {
                "Welche Adjektive beschreiben deinen Charakter am besten?",
                "Was ist dein bisher schönstes Erlebnis?",
                "Worauf bist du stolz?",
                "Inwiefern beeinflusst dein Beruf deine Beziehungen und deine Psyche?",
                "Welchen Wunsch möchtest du dir bald erfüllen?",
                "Wie geht es dir zurzeit?",
                "Wofür bist du dankbar? Was liebst du an deinem Leben?",
                "Welchen Stellenwert hat Familie in deinem Leben?",
                "Was wünscht du dir für deine Zukunft?",
                "In welchen Momenten bist du am glücklichsten?",
                "Wovor hast du Angst?",
                "Wer und was inspiriert dich? Wann fühlst du dich inspiriert?",
                "Wie beschreibst du deine Erziehung?",
                "Woran möchtest du an dir arbeiten?",
                "Inwiefern hast du dich in den letzten Jahren verändert?",
                "Wie beschreibst du die Beziehung zwischen dir und deinem Körper?",
                "Welches Verhalten anderer Menschen macht dich wütend und warum?",
                "Was macht für dich eine gute Freundschaft aus?",
                "Worüber machst du dir zurzeit Sorgen?",
                "Was unterscheidet dich von den meisten Menschen in deiner Generation?",
                "Was war die beste Entscheidung deines Lebens?",
                "Welchen Titel würdest du deinem aktuellen Lebensabschnitt geben?",
                "Worauf könntest du nicht verzichten?",
                "Was schätzt du am meisten an dir?",
                "Welche Entscheidung würdest du heute anders fällen?",
                "Wie hast du deine Kindheit erlebt?",
                "Welche Rolle spielt Religion und Spiritualität in deinem Leben?",
                "Fühlst du dich frei? Inwiefern fühlst du dich in deiner Freiheit eingeschränkt?",
                "Was ist deine größte Schwäche?",
                "Wie zufrieden bist du mit dem Status Quo deines Leben?",
                "Was sind die wichtigsten Werte (Top3) nach denen du Lebst?",
                "Was bedeutet eine Beziehung für dich?"};

        static List<string> fragenDich = new List<string>(uns);


        public static string getNextUnsQuestion()
        {
            if (fragenUns.Count == 0) { return "Ihr habt alle Uns-Fragen beantwortet"; }
            else
            {
                string question = fragenUns[0];
                fragenUns.Remove(question);
                return question;
            }
        }

        public static string getNextMichQuestion()
        {
            if (fragenMich.Count == 0) { return "Ihr habt alle Mich-Fragen beantwortet"; }
            else
            {
                string question = fragenMich[0];
                fragenMich.Remove(question);
                return question;
            }
        }

        public static string getNextDichQuestion()
        {
            if (fragenDich.Count == 0) { return "Ihr habt alle Dich-Fragen beantwortet"; }
            else
            {
                
                string question = fragenDich[0];
                fragenDich.Remove(question);
                return question;
            }
        }



    }
}