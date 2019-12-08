<head>
    <script src="https://unpkg.com/vue"></script>
</head>
<template>

    <div class="body">
        <br style="clear:both" />
        <h1>Test s&#248;gefelt opskrift</h1>
        <div id="StorePage">
            <br style="clear:both" />
            <div class="SearchBar">
                <input style="height: 32px; width: 704px;" type="text" v-model="searchParameter" placeholder="Search..." required>
            </div>
            <button class="test_btn" @click="sendRecipeRequest">Test</button>
            <span v-html="info">{{info}}</span>

            <br style="clear:both" />

        </div>
    </div>
</template>

<script>
    export default {
        name: 'StorePage',
        data: function () {
            return {
                test: 'Det virker',
                info: null,
                searchParameter: null,
                relevantStores: ""
            }
        },
        methods: {
            sendRecipeRequest() {
                this.$http.post('http://nyguldtand.azurewebsites.net/Home/viewASpeceficRecipe?words=' + this.searchParameter + '&stores=' + this.relevantStores,  {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    }
                }).then(response => (this.info = response.data))
            }
        },
        beforeMount() {
                        this.$root.$on('clickedSaveStores', (stores) => {
                this.relevantStores = stores;
            })
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

    /*.body {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }*/
    img{

    }
</style>

