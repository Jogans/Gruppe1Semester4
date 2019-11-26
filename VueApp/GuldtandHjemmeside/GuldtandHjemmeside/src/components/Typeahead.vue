<script>
    export default {
        data() {
            return {
                open: false,
                current: 0
            }
        },
        props: {
            suggestions: {
                type: Array,
                required: true
            },
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
            enter() {
                this.selection = this.matches[this.current];
                this.open = false;
            },
            up() {
                if (this.current > 0)
                    this.current--;
            },
            down() {
                if (this.current < this.matches.length - 1)
                    this.current++;
            },
            isActive(index) {
                return index === this.current;
            },
            change() {
                if (this.open == false) {
                    this.open = true;
                    this.current = 0;
                }
            },
            suggestionClick(index) {
                this.selection = this.matches[index];
                this.open = false;
            },
        }
    }
</script>
