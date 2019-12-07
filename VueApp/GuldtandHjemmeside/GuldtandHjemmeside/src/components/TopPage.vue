<template>
    <div class='body'>

        <br style="clear:both" />
        <button class="test_btn" @click="smallView">Opdater opskrift med valgte butikker</button>
        <br style="clear:both" />
        <span v-html="info">{{info}}</span>
        <br style="clear:both" />
        <br style="clear:both" />

    </div>
</template>

<script>
    export default {
        name: 'TopPage',
        props: {
        },
        data: function () {
            return {
                info: null,
                searchParameter: null,
                relevantStores: ""
            }
        },
        methods: {
            smallView() {
                this.$http.get('https://localhost:44324/Home/viewForSmallRecipe?stores=' + this.relevantStores, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => this.info = response.data)
            }
        },
        beforeMount() {
            this.smallView()
            this.$root.$on('clickedSaveStores', (stores) => {
                this.relevantStores = stores;
            })
        },
    };
</script>

<!-- Add 'scoped' attribute to limit CSS to this component only -->
<style scoped>
    ./*body {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }*/


    .textForPrice {
        display: block;
        position: relative;
        float: left;
        margin-left: 355px;
        font-size: 20px;
    }
</style>

