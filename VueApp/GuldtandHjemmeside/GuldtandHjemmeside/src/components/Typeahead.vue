<template>
    <div class="typeaheadhome">
        <!--   <div style="position:relative" v-bind:class="{'open':openSuggestion}">
            <input class="form-control" type="text" v-model="selection"
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
            </ul>
        </div> -->
    </div>
</template>

<script>
    //import Vue from 'vue';
    export default {
        data() {
            return {
                open: false,
                current: 0
            }
        },
        props: {
            // Array fra databasen med indhold
            suggestions: {
                type: Array,
                required: true
            },
            // 2vejs data binding som opdatere input værdien i selection propertien. 
            selection: {
                type: String,
                required: true,
                twoWay: true
            }
        },
        computed: {
            matches() {
                return this.suggestions.filter((str) => {
                    return str.indexOf(this.selection) >= 0;
                });
            },
            openSuggestion() {
                return this.selection !== "" &&
                    this.matches.length != 0 &&
                    this.open === true;
            }
        },
        methods: {
            //Metoder til at bruge piltasterne og vælge imellem elementer i dropdown menuen. op, ned, højre, venstre, enter, click.

            //When enter pressed on the input
            enter() {
                this.selection = this.matches[this.current];
                this.open = false;
            },
             //When up pressed while suggestions are open
            up() {
                if (this.current > 0)
                    this.current--;
            },
            //When up pressed while suggestions are open
            down() {
                if (this.current < this.matches.length - 1)
                    this.current++;
            },
            //For highlighting element
            isActive(index) {
                return index === this.current;
            },
            //When the user changes input
            change() {
                if (this.open == false) {
                    this.open = true;
                    this.current = 0;
                }
            },
            //When one of the suggestion is clicked
            suggestionClick(index) {
                this.selection = this.matches[index];
                this.open = false;
            },
        }
    }
    
</script>
<style>
    .typeaheadhome {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>
