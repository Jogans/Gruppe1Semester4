<template>
    <div class="calculatorTestHome">
        <br style="clear:both" />
        <h1>Calculator Test Site</h1>
        <button class="test_btn" @click="created">Test</button>
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
                searchParameter: null
            }
        },
        methods: {
            created() {
                this.$http.get('https://localhost:44324/Home/viewTotalPrice?words=marcus', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            }
        }
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

