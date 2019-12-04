<template>
    <div class='bodyTopPage'>
        <br style="clear:both" />
        <span v-html="info">{{info}}</span>
        <br style="clear:both" />

    </div>
</template>

<script>
    export default {
        name: 'FlæskestegalaMarcus',
        props: {
        },
        data: function () {
            return {
                info: null,
                searchParameter: null
            }
        },
        methods: {
            fullView() {
                this.$http.get('https://localhost:44324/Home/viewASpeceficRecipe?words=marcus', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            }
        },
        beforeMount() {
            this.fullView()
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
</style>

