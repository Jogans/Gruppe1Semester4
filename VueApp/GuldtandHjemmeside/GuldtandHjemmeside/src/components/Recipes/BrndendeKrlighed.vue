<template>
    <div class='bodyTopPage'>
        <br style="clear:both" />
        <span v-html="info">{{info}}</span>
        <br style="clear:both" />
        <button class="test_btn" @click="generateShoppingCart">Generer indkøbsliste</button>
        <span v-html="info2">{{info2}}</span>


        <br style="clear:both" />

    </div>
</template>

<script>
    export default {
        name: 'BrndendeKrlighed',
        data: function () {
            return {
                info: null,
                info2: null,
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
                this.$http.get('https://localhost:44324/Home/viewASpeceficRecipe?words=lighed', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            },
            generateShoppingCart() {
                this.$http.get('https://localhost:44324/Home/getShoppingCart?words=lighed' + '&stores=' + this.relevantStores, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info2 = response.data))
            },
            updateFunc() {
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

