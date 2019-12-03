<template>
    <!--  <SearchBar :triggerEvent="mounted" />  -->
    <div class="searchsite">
    <!--<div style="position:relative" v-bind:class="{'open':openSuggestion}">-->
        <!--<input class="form-control" type="text" v-model="selection"
               @keydown.enter='enter'
               @keydown.down='down'
               @keydown.up='up'
               @input='change' />
        <ul class="dropdown-menu" style="width:100%">
            <li v-for="suggestion in matches"
                v-bind:class="{'active': isActive($index)}"
                @click="suggestionClick($index)">
                <a href="#">{ suggestion }}</a>
            </li>
        </ul>-->
    </div>

</template>

<script>
    //import Searchbar from './components/Searchbar.vue';
   
        //components: {
        // Searchbar
        // },
        /*methods: {
            callFunction() {
                callFunction.Searchbar;
                }
            }
        }*/




        // components: { Searchbar  }

    
        
    
</script>

<style scoped>
    .searchsite {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>