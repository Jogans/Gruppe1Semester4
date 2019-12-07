<template>
    <div class='bodyTopPage'>
        <br style="clear:both" />
        <button class="test_btn" @click="fullView">Opdater opskrift med valgte butikker</button>
        <span v-html="info">{{info}}</span>
        <br style="clear:both" />

    </div>
</template>

<script>
    export default {
        name: 'Hjemmelavetlasagne',
        data: function () {
            return {
                info: null,
                searchParameter: null,
                relevantStores: ""
            }
        },
        methods: {
            updateStores() {
                this.$root.$on('clickedSaveStores', (stores) => {
                    this.relevantStores = stores;
                })
            },
            fullView() {
                this.$http.get('https://localhost:44324/Home/viewASpeceficRecipe?words=lasa' + '&stores=' + this.relevantStores, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            }
        },
        mounted() {
            this.fullView()
        },
        beforeMount() {
            this.$root.$on('clickedSaveStores', (stores) => {
                this.relevantStores = stores;
            })
        },
    };
</script>

<!-- Add 'scoped' attribute to limit CSS to this component only -->
<style scoped>
    .bodyTopPage {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>

