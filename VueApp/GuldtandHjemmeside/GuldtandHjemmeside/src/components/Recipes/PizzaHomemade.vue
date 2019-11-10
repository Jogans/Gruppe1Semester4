<template>
    <div class="bodyStorePage">
        <br style="clear:both" />
        <h1>Hjemmelavet pizza med tomatsovs, peperoni og ost</h1>

        <div class="recepie">
            <div class="ingredienser">
                <p class="p2"><span class="s1">45 min. + h&#230;ve- og bagetid<br></span>Til 4 personer</p>


                <div class="image">
                    <img src="@/assets/Pics/Pizza_Picture.jpg" />
                </div>
                <br style="clear:both" />
                <p class="p3"><strong>INGREDIENSER</strong></p>
                <div class="i1">
                    <p class="p3"><strong>Pizzadej</strong></p>
                    <ul>
                        <li class="p4">15 g g&#230;r</li>
                        <li class="p4">3 1/2 dl lunkent vand</li>
                        <li class="p4">1 spsk olivenolie</li>
                        <li class="p4">1 1/2 tsk salt</li>
                        <li class="p4">225 g fuldkornsmel</li>
                        <li class="p4">
                            ca. 225 g italiensk hvedemel
                        </li>
                    </ul>
                </div>
                <div class="i2">
                    <p class="p2"><strong><span class="s1">Pizzasauce</span></strong></p>
                    <ul>
                        <li class="p4">1/2 l&#248;g</li>
                        <li class="p4">1 fed hvidl&#248;g</li>
                        <li class="p4">1 ds hakkede tomater</li>
                        <li class="p4">1/2 spsk honning eller sirup</li>
                        <li class="p4">1/2 tsk oregano</li>
                        <li class="p4">1/2 tsk basilikum</li>
                        <li class="p4">1/2 tsk chiliflager</li>
                        <li class="p4">1/2 tsk salt</li>
                    </ul>
                </div>
                <div class="i3">
                    <p class="p3"><strong>Topping</strong></p>
                    <ul>
                        <li class="p4">2 peberfrugter</li>
                        <li class="p4">125 g champignoner</li>
                        <li class="p4">100 g pepperoni</li>
                        <li class="p4">100 g ost maks. 30+</li>
                    </ul>
                </div>
            </div>

            <br style="clear:both" />

            <div class="f1">
                <h3>FREMGANGSM&#197;DE</h3>
                <p>1. R&#248;r g&#230;ren ud i lunkent vand, og tils&#230;t de &#248;vrige ingredienser til dejen. &#230;lt dejen 5 min., og lad den h&#230;ve ca. 1 time.</p>
                <p>2. Pil l&#248;g og hvidl&#248;g, og riv dem groft. H&#230;ld tomaterne i en sigte over en sk&#229;l. Blend tomaterne med de &#248;vrige ingredienser til saucen, og juster tykkelsen med den afdryppede tomatsaft. Lad saucen tr&#230;kke ved stuetemperatur 1/2 times tid.</p>
                <p>3. Sk&#230;r peberfrugt i tynde strimler og champignon i skiver. Sk&#230;r p&#248;lsen i tynde skiver, og riv osten groft.</p>
                <p>4. S&#230;t dine bageplader i ovnen, og t&#230;nd p&#229; 250-275 grader varmluft - s&#229; h&#248;jt, din ovn kan komme op.</p>
                <p>5. Vend dejen ud p&#229; et meldrysset bord, og del den i 4 lige store stykker. Form dem til kugler, rul dem tyndt ud til bunde, og l&#230;g dem p&#229; bagepapir. Sm&#248;r saucen p&#229; pizza-erne, men lad kanten g&#229; fri.</p>
                <p>6. Fordel peberfrugt, champignon, pepperoni og ost ovenp&#229;. Flyt pizzaerne ind p&#229; de brandvarme bageplader med en pizzaspade eller ved hj&#230;lp af en plade, bakke eller et br&#230;t.</p>
                <p>7. Bag, til dejen er gennembagt, og osten er smeltet - ca. 10 min. Server straks.</p>
                <p><strong><br>Tip!</strong> Udvid fyldet med andre gr&#248;ntsager - gerne rester af dampede eller stegte gr&#248;ntsager eller kogte kartofler.</p>
            </div>
        </div>
    </div>
</template>

<script>
        export default {
        name: 'PizzaHomemade',
        props: {
        }
    };
</script>

<style scoped>

        img{
    display: block;
    position: relative;
    width: 525px;
    height: 300px;
    float: left;
}

    .i1 {
        float: left;
        position: relative;
    }

    .i2 {
        float: left;
        position: relative;
        padding-left: 10px;
    }

    .i3 {
        float: left;
        position: relative;
        padding-left: 10px;
    }
            .bodyStorePage {
    width: 100%;
    max-width: 65%;
    margin: auto;
}
</style>