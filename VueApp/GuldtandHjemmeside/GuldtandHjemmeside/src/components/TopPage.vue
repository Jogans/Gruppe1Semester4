<template>
    <div class='body'>
        <h1>Top retter</h1>
        <p>Her ses en liste af ugens billigste retter at lave - baseret p&aring;     de aktuelle tilbud i de valgte butikker.</p>
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
                this.$http.get('https://localhost:44324/Recipe/viewForSmallRecipe?stores=' + this.relevantStores, {
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
    . /*body {
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

