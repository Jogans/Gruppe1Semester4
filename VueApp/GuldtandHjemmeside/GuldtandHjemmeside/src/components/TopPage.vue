<template>
    <div class="bodyTopPage">
        <br style="clear:both" />
        <h1>Top Page</h1>
        <div class="viewOfRecepie">
            <div class="imageOfRecepie">
                <img scr="" alt="billede"/>
            </div>
            <div class="textForPrice">
                {{recepie.name}} <br />
                {{recepie.priceOrginal}}

            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'TopPage',
        data() {
            return {
                recepie: {
                    pic: 'Pizza_Picture.jpg',
                    name: 'Pizza med tomatsovs, peperoni og ost',
                    priceOrginal: 'xx kr',
                    alt: 'Pizza',
                    info: 'Bla bla?'
                }
            }
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .bodyTopPage {
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
        width: 850px;
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

