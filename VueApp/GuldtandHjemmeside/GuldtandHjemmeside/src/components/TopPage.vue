<template>
    <div class='bodyTopPage'>
        <br style="clear:both" />
        <h1>Test af lille opskriftvisning</h1>
        <br style="clear:both" />
        <span v-html="info">{{info}}</span>

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
                searchParameter: null
            }
        },
        methods: {
            created() {
                this.$http.get('https://localhost:44324/Home/viewForSmallRecipe?words=marcus', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            }
        },
        beforeMount() {
            this.created()
        }
    };
</script>

<!-- Add 'scoped' attribute to limit CSS to this component only -->
<style scoped>
    .bodyTopPage {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }


    .textForPrice {
        display: block;
        position: relative;
        float: left;
        margin-left: 355px;
        font-size: 20px;
    }
</style>

