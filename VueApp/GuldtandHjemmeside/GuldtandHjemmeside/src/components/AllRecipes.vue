<template>
    <div class="body">
        <br style="clear:both" />
        <h1>Alle retter</h1>
        <p>Her ses alle retter tilf&oslash;jet til siden</p>
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
        name: 'AllRecipes',
  data: function () {
            return {
                info: null,
                searchParameter: null,
                relevantStores: ""
            }
        },
        methods: {
            smallView() {
                this.$http.get('https://nyguldtand.azurewebsites.net/Recipe/viewForSmallRecipe?stores=' + this.relevantStores+ '&count=20', {
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

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

        /*.body {
            width: 100%;
            max-width: 65%;
            margin: auto;
    }*/
</style>

