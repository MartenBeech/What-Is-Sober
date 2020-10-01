using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AQuestion : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action()
    {
        Rng rng = new Rng();

        int sips = rng.Range(2, 5);

        actions.Add("<b>Would you rather:</b>\nGo back to age 5 with your current knowledge\n<b>OR;</b>\nKnow everything your future self will ever learn\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nBe able to control animals with your mind\n<b>OR;</b>\nBe able to control electronics with your mind\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nHave unlimited free airplane tickets\n<b>OR;</b>\nHave unlimited free food at any restaurant\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nBe forced to dance every time you heard music\n<b>OR;</b>\nBe forced to sing along to any song you heard\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nHave all your clothes fit perfectly\n<b>OR;</b>\nHave the most comfortable bedclothes in existence\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nMove to a new city or town every year\n<b>OR;</b>\nNever be able to leave the city or town you were born in\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nNever use a fork again\n<b>OR;</b>\nNever use a spoon again\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nAll dogs try to attack you on sight\n<b>OR;</b>\nAll cats try to attack you on sight\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nBe able to understand what animals say\n<b>OR;</b>\nAnimals can understand what you say\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nBe a famous actor\n<b>OR;</b>\nBe a famous director\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nBe able to control fire\n<b>OR;</b>\nBe able to control water\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nPerfectly paint anything you want\n<b>OR;</b>\nPerfectly calculate anything inside your head\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nAlways win against your friends in any game\n<b>OR;</b>\nAlways lose against your friends in any game\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nEat only spicy food\n<b>OR;</b>\nEat only food with no seasoning\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nNever be able to wear pants\n<b>OR;</b>\nNever be able to wear a jacket\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nHave a horrible short-term memory\n<b>OR;</b>\nHave a horrible long-term memory\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nGo a month without taking a shower/bath\n<b>OR;</b>\nGo a month with only one pair of clothes\n\nThe minority takes " + sips + " sips");
        actions.Add("<b>Would you rather:</b>\nGo a year without watching any movies\n<b>OR;</b>\nGo a year without watching any series\n\nThe minority takes " + sips + " sips");

        actions.Add("<b>Who is most likely to:</b>\nPass out before midnight\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nGet in a fight with a stranger\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nGo to a nudist camp\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nBecome a parent soon\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nBecome a stand-up comedian\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nAppear on some reality show\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nBecome professional in any sport\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nCry during a movie\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nMake a first date really awkward\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nBecome a professional cook/baker\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nForget new people's names\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nWalk into a glass door\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nSecretly be an alien\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nMake a drunk call\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nCheck their phone all the time\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nMake a speech where every 2nd word is 'umm'\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nStay in bed all day\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nSurvive a zombie apocalypse\n\nThe player(s) with most votes takes " + sips + " sips");
        actions.Add("<b>Who is most likely to:</b>\nBe pointed at right now, so they have to drink\n\nThe player(s) with most votes takes " + sips + " sips");

        Misc.info.GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
    }
}
