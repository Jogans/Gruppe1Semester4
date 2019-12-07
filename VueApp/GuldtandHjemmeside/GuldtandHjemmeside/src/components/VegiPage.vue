<template>
    <div class="body">
        <h1>Vegetar retter</h1>
        <p>Her ses udelukkende retter, som er vegetar-venlige</p>

        <br style="clear:both" />

        <div class="blacklist">
            <p class="blacklist-p">Blacklist retter der ikke er vegetar-venlige.</p>
            <button @click="addCategory" style="margin: 10px">Find</button>

            <select v-model='selected' id='category' style="margin: 10px">
                <option v-bind:key="kategoriElement" v-for="kategoriElement in kategori">{{kategoriElement}}</option>
            </select>
            <button @click="addToBlackList" style="margin: 10px">Send til blacklist</button><p />

            <table class="blacklist-table">
                <th>Blacklist</th>
                <tr v-bind:key="blacklistElement" v-for="blacklistElement in blacklist"><td>{{blacklistElement}}</td></tr><!---->
            </table>
        </div>

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


    .blacklist {
        border: 1px solid #bebebe;
        padding: 10px;
    }

    .blacklist-p {
        margin-top:0px;
    }

    .blacklist-table {
        border: 1px solid #bebebe;
        padding: 5px 10px;
    }
</style>

