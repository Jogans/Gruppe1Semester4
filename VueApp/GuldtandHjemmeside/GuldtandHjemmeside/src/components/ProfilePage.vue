<template>
    <div class="bodyProfilePage">
        <br style="clear:both" />
        <h2>Brugernavn: </h2>

        <button class="resetPassword">Ændre adgangskode</button>
        <br style="clear:both" />
        <div class="Pref">
            <h2>Indstillinger</h2>
            For at ændre indstillinger i forhold til butikker bruges sidebaren til venstre.
        </div>
        <div class="DishesMade">
            <h2>Retter oprettet af dig:</h2>
            <div class="viewOfRecepie">
                <div class="imageOfRecepie">
                    <img src="@/assets/Pics/Pizza_Picture.jpg" />
                </div>
                <div class="textForPrice">
                    <div style="font-size: 25px;">
                        {{recepie.name}} <br />
                    </div>
                    Original pris: {{recepie.priceOrginal}}kr. <br />
                    Pris med rabat: {{recepie.priceDiscount}}kr. <br />
                    Laveste mulige pris: {{recepie.priceLowest}}kr. <br />

                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'ProfilePage',
        data() {
            return {
                recepie: {
                    pic: '@/assets/Pics/Pizza_Picture.jpg',
                    name: 'Hjemmelavet pizza med tomatsovs, peperoni og ost',
                    priceOrginal: '50',
                    priceDiscount: '35',
                    priceLowest: '35',
                    alt: 'Pizza',
                    info: 'Bla bla?'
                }
            }
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .bodyProfilePage {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }

    img{
        display: block;

    position: absolute;
    width: 350px;
    height: 200px;
}
        .viewOfRecepie {
        width: 900px;
        height: 200px;
        border: 2px solid;
        padding: 2px;
        margin: 20px;
    }

    .textForPrice{
        display: block;
        position: relative;
        float: left;
        margin-left: 355px;
        font-size: 20px;
    }

</style>

