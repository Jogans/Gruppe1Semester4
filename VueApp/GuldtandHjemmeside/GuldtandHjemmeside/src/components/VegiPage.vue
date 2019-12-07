<template>
    <div class="body">
        <br style="clear:both" />
        <h1>Vegetar fis</h1>
        <button @click="addCategory" style="margin: 10px">Find</button>   

        <select v-model='selected' id='category' style="margin: 10px">
        <option v-bind:key="kategoriElement" v-for="kategoriElement in kategori">{{kategoriElement}}</option>
        </select>
        <button @click="addToBlackList" style="margin: 10px">Send til blacklist</button><p />

        <table border="1">
            <th>Blacklist</th>
            <tr v-bind:key="blacklistElement" v-for="blacklistElement in blacklist"><td>{{blacklistElement}}</td></tr><!---->
        </table>
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
                kategori:[],
                blacklist: "",
                selected: ""
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
                this.$http.get('https://localhost:44323/kategori/insertAndGetBlacklist?category=' + this.selected, {
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
    /*.body{
        width: 100%;
        max-width: 65%;
        margin: auto;
    }*/
</style>

