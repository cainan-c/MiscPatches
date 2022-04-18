using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using BepInEx;
using HarmonyLib;

namespace MiscPatches
{
    [HarmonyPatch]
    public class MirrorMode : MonoBehaviour
    {
        [HarmonyPatch(typeof(EnsoGameManager), "Update")]
        [HarmonyPostfix]
        static void customUpdate()
        {
            //GameObject Parent Canvas
            GameObject lane_left = GameObject.Find("lane_left");
            lane_left.transform.rotation =  new Quaternion(0, 180, 0, 0);
            lane_left.transform.position = new Vector3(711, 132, 90);

            GameObject lane_hide = GameObject.Find("lane_hide");
            lane_hide.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject icon_course = GameObject.Find("icon_course");
            icon_course.transform.position = new Vector3(830, 142, 90);

            GameObject taiko_indicator = GameObject.Find("taiko_indicator");
            taiko_indicator.transform.position = new Vector3(558, 113, 90);

            GameObject score_base = GameObject.Find("score_base");
            score_base.transform.rotation = new Quaternion(0, 180, 0, 0);
            score_base.transform.position = new Vector3(680, 44, 90);

            GameObject hit_effect = GameObject.Find("hit_effect");
            hit_effect.transform.position = new Vector3(688, 132, 90);

            GameObject ComboNumber = GameObject.Find("ComboNumber");
            ComboNumber.transform.position = new Vector3(558, 163, 90);

            GameObject icon_option_set_enso = GameObject.Find("icon_option_set_enso");
            icon_option_set_enso.transform.position = new Vector3(782, 184, 90);

            GameObject branch_effect = GameObject.Find("branch_effect");
            branch_effect.transform.position = new Vector3(408, 293, 90);

            GameObject RendaNumber = GameObject.Find("RendaNumber");
            RendaNumber.transform.position = new Vector3(340, 395, 90);

            GameObject ComboFukidashiComboYa = GameObject.Find("ComboFukidashi/ComboYa");
            ComboFukidashiComboYa.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject ComboFukidashiNum = GameObject.Find("ComboFukidashi/Num");
            ComboFukidashiNum.transform.position = new Vector3(385, 485, 90);

            GameObject ComboFukidashiText = GameObject.Find("ComboFukidashi/Text");
            ComboFukidashiText.transform.position = new Vector3(385, 365, 90);

            GameObject ComboFukidashi = GameObject.Find("ComboFukidashi");
            ComboFukidashi.transform.position = new Vector3(71, 416, 90);

            GameObject don_fusen_dummy = GameObject.Find("don_fusen_dummy");
            don_fusen_dummy.transform.position = new Vector3(333, 191, 90);

            //GameObject Parent CanvasBack
            GameObject renda_effect = GameObject.Find("renda_effect");
            renda_effect.transform.rotation = new Quaternion(0, 180, 0, 0);
            renda_effect.transform.position = new Vector3(960, 540, 90);

            GameObject don_normal_dummy = GameObject.Find("don_normal_dummy");
            don_normal_dummy.transform.rotation = new Quaternion(0, 180, 0, 0);
            don_normal_dummy.transform.position = new Vector3(760, 410, 90);

            GameObject TamashiGaugeP1Sprite = GameObject.Find("TamashiGaugeP1Sprite");
            TamashiGaugeP1Sprite.transform.position = new Vector3(-360, 296, 90);

            GameObject TamashiGaugeP1Sprite_Gauge_Frame01 = GameObject.Find("TamashiGaugeP1Sprite/Gauge/Frame01");
            TamashiGaugeP1Sprite_Gauge_Frame01.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject TamashiGaugeP1Sprite_Gauge_Lump = GameObject.Find("TamashiGaugeP1Sprite/Gauge/Lump");
            TamashiGaugeP1Sprite_Gauge_Lump.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject TamashiGaugeP1Sprite_Gauge_Rainbow = GameObject.Find("TamashiGaugeP1Sprite/Gauge/Rainbow");
            TamashiGaugeP1Sprite_Gauge_Rainbow.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject TamashiGaugeP1Sprite_Gauge_Frame02 = GameObject.Find("TamashiGaugeP1Sprite/Gauge/Frame02");
            TamashiGaugeP1Sprite_Gauge_Frame02.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject TamashiGaugeP1Sprite_Gauge_LumpHandleL = GameObject.Find("TamashiGaugeP1Sprite/Gauge/LumpHandleL");
            TamashiGaugeP1Sprite_Gauge_LumpHandleL.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject TamashiGaugeP1Sprite_Gauge_LumpHandleS = GameObject.Find("TamashiGaugeP1Sprite/Gauge/LumpHandleS");
            TamashiGaugeP1Sprite_Gauge_LumpHandleS.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject TamashiGaugeP1Sprite_Gauge_uiClearText = GameObject.Find("TamashiGaugeP1Sprite/Gauge/uiClearText");
            TamashiGaugeP1Sprite_Gauge_uiClearText.transform.position = new Vector3(-550, 296, 90);

            GameObject TamashiGaugeP1Sprite_Tama = GameObject.Find("TamashiGaugeP1Sprite/Tama");
            TamashiGaugeP1Sprite_Tama.transform.position = new Vector3(-815, 321, 90);

            GameObject TamashiGaugeP1Sprite_ClearOver = GameObject.Find("TamashiGaugeP1Sprite/ClearOver");
            TamashiGaugeP1Sprite_ClearOver.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject lane = GameObject.Find("/CanvasBack/lane");
            lane.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject lane_target = GameObject.Find("/CanvasBack/lane_target");
            lane_target.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject lane_hit = GameObject.Find("/CanvasBack/lane_hit");
            lane_hit.transform.rotation = new Quaternion(0, 180, 0, 0);

            //GameObject Parent CanvasFg
            GameObject action_balloon = GameObject.Find("action_balloon");
            action_balloon.transform.position = new Vector3(315, 0, 90);

            GameObject action_balloon_miss = GameObject.Find("action_balloon/don/miss");
            action_balloon_miss.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject action_balloon_break = GameObject.Find("action_balloon/don/break");
            action_balloon_break.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject action_balloon_start = GameObject.Find("action_balloon/don/start");
            action_balloon_start.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject action_balloon_hit_bg = GameObject.Find("action_balloon/don/hit/bg");
            action_balloon_hit_bg.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject gogo_effect = GameObject.Find("gogo_effect");
            gogo_effect.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject Timer = GameObject.Find("Timer");
            Timer.transform.position = new Vector3(700, 0, 90);

            GameObject ActionResult = GameObject.Find("DondaFullCombo");
            ActionResult.transform.position = new Vector3(123, 121, 90);

            GameObject DondaFullCombo = GameObject.Find("DondaFullCombo");
            DondaFullCombo.transform.position = new Vector3(-252, 154, 90);

            GameObject FullCombo = GameObject.Find("FullCombo");
            FullCombo.transform.position = new Vector3(-252, 154, 90);

            GameObject Fail = GameObject.Find("Fail");
            Fail.transform.position = new Vector3(-252, 154, 90);

            GameObject Success = GameObject.Find("Success");
            Success.transform.position = new Vector3(-252, 154, 90);

            GameObject PlayerName = GameObject.Find("PlayerName");
            PlayerName.transform.position = new Vector3(724, 252, 90);

            GameObject genre = GameObject.Find("genre");
            genre.transform.position = new Vector3(-720, 420, 90);

            GameObject uiText_genre_name = GameObject.Find("uiText_genre_name");
            uiText_genre_name.transform.position = new Vector3(-720, 421, 90);

            GameObject uiText_song_title = GameObject.Find("uiText_song_title");
            uiText_song_title.transform.position = new Vector3(-270, 472, 90);

            GameObject uiText_song_title_center = GameObject.Find("uiText_song_title_center");
            uiText_song_title_center.transform.position = new Vector3(-720, 472, 90);

            GameObject uiText_rule = GameObject.Find("uiText_rule");
            uiText_rule.transform.position = new Vector3(-270, 472, 90);

            GameObject ActionKusudama = GameObject.Find("ActionKusudama");
            ActionKusudama.transform.rotation = new Quaternion(0, 180, 0, 0);


            //GameObject Parent onp_jump_player
            GameObject jump0 = GameObject.Find("jump0");
            jump0.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump1 = GameObject.Find("jump1");
            jump1.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump2 = GameObject.Find("jump2");
            jump2.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump3 = GameObject.Find("jump3");
            jump3.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump4 = GameObject.Find("jump4");
            jump4.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump5 = GameObject.Find("jump5");
            jump5.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump6 = GameObject.Find("jump6");
            jump6.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump7 = GameObject.Find("jump7");
            jump7.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump8 = GameObject.Find("jump8");
            jump8.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump9 = GameObject.Find("jump9");
            jump9.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump10 = GameObject.Find("jump10");
            jump10.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump11 = GameObject.Find("jump11");
            jump11.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump12 = GameObject.Find("jump12");
            jump12.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump13 = GameObject.Find("jump13");
            jump13.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump14 = GameObject.Find("jump14");
            jump14.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump15 = GameObject.Find("jump15");
            jump15.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump16 = GameObject.Find("jump16");
            jump16.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump17 = GameObject.Find("jump17");
            jump17.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump18 = GameObject.Find("jump18");
            jump18.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump19 = GameObject.Find("jump19");
            jump19.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump20 = GameObject.Find("jump20");
            jump20.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump21 = GameObject.Find("jump21");
            jump21.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump22 = GameObject.Find("jump22");
            jump22.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump23 = GameObject.Find("jump23");
            jump23.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump24 = GameObject.Find("jump24");
            jump24.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump25 = GameObject.Find("jump25");
            jump25.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump26 = GameObject.Find("jump26");
            jump26.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump27 = GameObject.Find("jump27");
            jump27.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump28 = GameObject.Find("jump28");
            jump28.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump29 = GameObject.Find("jump29");
            jump29.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump30 = GameObject.Find("jump30");
            jump30.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump31 = GameObject.Find("jump31");
            jump31.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump32 = GameObject.Find("jump32");
            jump32.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump33 = GameObject.Find("jump33");
            jump33.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump34 = GameObject.Find("jump34");
            jump34.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump35 = GameObject.Find("jump35");
            jump35.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump36 = GameObject.Find("jump36");
            jump36.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump37 = GameObject.Find("jump37");
            jump37.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump38 = GameObject.Find("jump38");
            jump38.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump39 = GameObject.Find("jump39");
            jump39.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump40 = GameObject.Find("jump40");
            jump40.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump41 = GameObject.Find("jump41");
            jump41.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump42 = GameObject.Find("jump42");
            jump42.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump43 = GameObject.Find("jump43");
            jump43.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump44 = GameObject.Find("jump44");
            jump44.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump45 = GameObject.Find("jump45");
            jump45.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump46 = GameObject.Find("jump46");
            jump46.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump47 = GameObject.Find("jump47");
            jump47.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump48 = GameObject.Find("jump48");
            jump48.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump49 = GameObject.Find("jump49");
            jump49.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump50 = GameObject.Find("jump50");
            jump50.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump51 = GameObject.Find("jump51");
            jump51.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump52 = GameObject.Find("jump52");
            jump52.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump53 = GameObject.Find("jump53");
            jump53.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump54 = GameObject.Find("jump54");
            jump54.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump55 = GameObject.Find("jump55");
            jump55.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump56 = GameObject.Find("jump56");
            jump56.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump57 = GameObject.Find("jump57");
            jump57.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump58 = GameObject.Find("jump58");
            jump58.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump59 = GameObject.Find("jump59");
            jump59.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump60 = GameObject.Find("jump60");
            jump60.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump61 = GameObject.Find("jump61");
            jump61.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump62 = GameObject.Find("jump62");
            jump62.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject jump63 = GameObject.Find("jump63");
            jump63.transform.rotation = new Quaternion(0, 180, 0, 0);

            //No Parent
            GameObject onp_player = GameObject.Find("onp_player");
            onp_player.transform.rotation = new Quaternion(0, 180, 0, 0);

            GameObject Score1P = GameObject.Find("Score1P");
            Score1P.transform.position = new Vector3(730, 44, 0);

        }
    }
}