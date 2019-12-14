<template>
    <div class="calculatorTestHome">
        <br style="clear:both" />
        <h1>Calculator Test Site</h1>
        <button class="test_btn" @click="created">Test</button>
        <br style="clear:both" />
        <span v-html="info">{{info}}</span>
    </div>
</template>

<script>
    export default {
        name: 'TestCalculator',
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
            created() {
                this.$http.get('https://nyguldtand.azurewebsites.net/Home/ViewNormalPrice?words=lasa' + '&stores=' + this.relevantStores, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            }
        },
        beforeMount() {
            this.$root.$on('clickedSaveStores', (stores) => {
                this.relevantStores = stores;
            })
        },
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .calculatorTestHome {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>

