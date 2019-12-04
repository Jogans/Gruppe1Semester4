<template>
    <div class="bodySearchBar">
        <br style="clear:both" />
        <br style="clear:both" />
        <div class="SearchBar">
            <!-- <typeahead :suggestions="searchoptions" :selection.sync="value"> </typeahead>  -->
            <input style="height: 32px; width: 704px;" type="text" v-model="searchParameter" placeholder="Search..." required>
            <autocomplete :items="[ 'Apple', 'Banana', 'Orange', 'Mango', 'Pear', 'Peach', 'Grape', 'Tangerine', 'Pineapple']" />
        
            <script type="text/x-template" id="autocomplete">
                <div class="autocomplete">
                    <input type="text" @input="onChange" v-model="search" @keyup.down="onArrowDown" @keyup.up="onArrowUp" @keyup.enter="onEnter" />
                    <ul id="autocomplete-results" v-show="isOpen" class="autocomplete-results">
                        <li class="loading" v-if="isLoading">
                            Loading results...
                        </li>
                        <li v-else v-for="(result, i) in results" :key="i" @click="setResult(result)" class="autocomplete-result" :class="{ 'is-active': i === arrowCounter }">
                            {{ result }}
                        </li>
                    </ul>

                </div>
            </script>

        </div>
        


        <div class="SearchBarBtn">
            <button class="SearchRecepie" style="height: 32px;" type="button">S&#248;g opskrift</button>
            <button style="height: 32px;" @click="mounted" type="button">S&#248;g ingrediens</button>
            <!--<button style="height: 32px;" @click="$emit('triggerEvent')" type="button">S&#248;g ingrediens</button> -->
        </div>

        <br style="clear:both" />

        <span v-html="info">{{info}}</span>
    </div>
</template>

<script>

    //import Typeahead from './components/Typeahead.vue'
    export default {
        name: 'SearchBar',
        //components: { Typeahead },

        props: {
            //['searchoptions', 'value']


            //searchoptions: ['kød', 'grønsager', 'agurk'],
            //value: ''
        },

        
             
        data: function () {
            return {
                test: 'Det virker',
                info: null,
                searchParameter: null
                //searchoptions: ['kød', 'grønsager', 'agurk'],
                //value: ''
            }
               /* {
                    searchoptions: [
                        'kød', 'grønsager', 'agurk', 'D', 'K', 'M'
                    ],
                    value: ''
                }*/
            },   


        methods: {
            mounted() {
                //this.$router.push({ name: 'Searchsite' })
                //this.$router.go({ path: 'Searchsite' })

                this.$http.get('https://localhost:44324/Home/searchProducts?words=' + this.searchParameter, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.info = response.data;
                    this.$router.push('/Searchsite');
                })
            }








        }
    }


</script>

<style scoped>
    .SearchBar {
        float: left;
        display: inline-block;
        color: black;
        font-size: 24px;
        font-family: verdana;
        text-align: left;
        margin-top: 0px;
        float: left;
        margin: 0px;
        line-height: 40px;
    }

    .SearchBarBtn {
        float: left;
        display: block;
        color: black;
        font-size: 24px;
        float: left;
        margin: 6px;
        padding-right: 15px;
        padding-bottom: 10px;
    }

    .bodySearchBar {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>
