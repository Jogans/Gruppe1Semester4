<template>
    <div class='body'>
        <div class="antalPersoner">
            <br style="clear:both" />
            <br style="clear:both" />
            <select v-model="count">
                <option value="1">1 Person</option>
                <option value="2">2 Personer</option>
                <option value="3">3 Personer</option>
                <option value="4" selected>4 Personer</option>
                <option value="5">5 Personer</option>
                <option value="6">6 Personer</option>
                <option value="7">7 Personer</option>
                <option value="8">8 Personer</option>
                <option value="9">9 Personer</option>
                <option value="10">10 Personer</option>
            </select>
        </div>
        <br style="clear:both" />
        <button class="test_btn" @click="fullView">Opdater opskrift med personer</button>
        <br style="clear:both" />
        <span v-html="info">{{info}}</span>
        <br style="clear:both" />
        <button class="test_btn" @click="generateShoppingCart">Generer indk&oslash;bsliste</button>
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
                relevantStores: "",
                count: 4
            }
        },
        methods: {
            updateStores() {
                this.$root.$on('clickedSaveStores', (stores) => {
                    this.relevantStores = stores;
                })
            },
            fullView() {
                this.$http.get('https://nyguldtand.azurewebsites.net/Recipe/ViewASpeceficRecipe?words=lighed' + '&count=' + this.count, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            },
            generateShoppingCart() {
                this.$http.get('https://nyguldtand.azurewebsites.net/Recipe/GetShoppingCart?words=lighed' + '&stores=' + this.relevantStores, {
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
</style>

