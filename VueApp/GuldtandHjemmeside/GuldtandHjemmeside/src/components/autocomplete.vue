<template>
     <div class="autocomplete">
        <!--<input type="text"
               @input="onChange"
               v-model="search"
               @keydown.down="onArrowDown"
               @keydown.up="onArrowUp"
               @keydown.enter="onEnter" />
        <ul id="autocomplete-results"
            v-show="isOpen"
            class="autocomplete-results">
            <li class="loading"
                v-if="isLoading">
                Loading results...
            </li>
            <li v-else
                v-for="(result, i) in results"
                :key="i"
                @click="setResult(result)"
                class="autocomplete-result"
                :class="{ 'is-active': i === arrowCounter }">
                { result }}
            </li>
        </ul>-->
    </div>
        

</template>

<script>
    //export default {
    //    name: 'autocomplete',
    //    props: {
    //        items: {
    //            type: Array,
    //            required: false,
    //            default: () => [],
    //        },
    //        isAsync: {
    //            type: Boolean,
    //            required: false,
    //            default: false,
    //        },
    //    },
    //    data() {
    //        return {
    //            isOpen: false,
    //            results: [],
    //            search: '',
    //            isLoading: false,
    //            arrowCounter: 0,
    //        };
    //    },
    //    methods: {
    //        onChange() {
    //            // Let's warn the parent that a change was made
    //            this.$emit('input', this.search);
    //            // Database async method call, async t
    //            if (this.isAsync) {
    //                this.isLoading = true;
    //            } else {
    //                // Let's flat our array
    //                this.filterResults();
    //                this.isOpen = true;
    //            }
    //        },
    //        filterResults() {
    //            // first uncapitalize all the things
    //            this.results = this.items.filter((item) => {
    //                return item.toLowerCase().indexOf(this.search.toLowerCase()) > -1;
    //            });
    //        },
    //        //Listen to event and set searchvalue to searchterm
    //        setResult(result) {
    //            this.search = result;
    //            this.isOpen = false;
    //        },
    //        //support for arrow keys
    //        onArrowDown(evt) {
    //            if (this.arrowCounter < this.results.length) {
    //                this.arrowCounter = this.arrowCounter + 1;
    //            }
    //        },
    //        onArrowUp() {
    //            if (this.arrowCounter > 0) {
    //                this.arrowCounter = this.arrowCounter - 1;
    //            }
    //        },
    //        onEnter() {
    //            this.search = this.results[this.arrowCounter];
    //            this.isOpen = false;
    //            this.arrowCounter = -1;
    //        },
    //        handleClickOutside(evt) {
    //            if (!this.$el.contains(evt.target)) {
    //                this.isOpen = false;
    //                this.arrowCounter = -1;
    //            }
    //        }
    //    },
    //    watch: {
    //        items: function (val, oldValue) {
    //            // actually compare them
    //            if (val.length !== oldValue.length) {
    //                this.results = val;
    //                this.isLoading = false;
    //            }
    //        },
    //    },
    //    //closes the list if user clicks outside
    //    mounted() {
    //        document.addEventListener('click', this.handleClickOutside)
    //    },
    //    destroyed() {
    //        document.removeEventListener('click', this.handleClickOutside)
    //    }
    //};
</script>



<style>
    /*.autocomplete {
        position: relative;
    }

    .autocomplete-results {
        padding: 0;
        margin: 0;
        border: 1px solid #eeeeee;
        height: 120px;
        overflow: auto;
        width: 100%;
    }

    .autocomplete-result {
        list-style: none;
        text-align: left;
        padding: 4px 2px;
        cursor: pointer;
    }

        .autocomplete-result.is-active,
        .autocomplete-result:hover {
            background-color: #4AAE9B;
            color: white;
        }*/
</style> 