<template>
    <div class="bodyVegiPage">
        <br style="clear:both" />
        <h1>Vegetar fis</h1>
        <button @click="addCategory">Find</button>

        <select v-model='kategoriParameter' id='category'>
        <div v-html="kategori">{{kategori}}</div>
        </select>
        <button @click="addToBlackList">Send til blacklist</button><p />

        <div v-html="blacklist">{{blacklist}}</div><!---->
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
    </div>
</template>

<script>
    export default {
        name: 'VegiPage',
        data: function () {
            return {
                kategori: "",
                blacklist: "",
                kategoriParameter: null
            }
        },
        methods: {
            addCategory() {
                this.$http.get('https://localhost:44323/kategori/getAllCategories', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (
                    this.kategori = response.data))
            },
            addToBlackList() {
                this.kategoriParameter = document.getElementById("category").nodeValue;
                this.$http.get('https://localhost:44323/kategori/insertAndGetBlacklist?category=' + this.kategoriParameter, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (
                    this.blacklist = response.data))
            }
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
        .bodyVegiPage {
    width: 100%;
    max-width: 65%;
    margin: auto;
}
</style>

