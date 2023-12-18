<template>
  <div id="footer">
    <div>
      <a href="https://beian.miit.gov.cn/" target="_blank">赣ICP备2021003855号-1</a>
    </div>
    <div>
      <a href="https://beian.mps.gov.cn/#/query/webSearch?code=36010902000992" rel="noreferrer" target="_blank">
        <img style="width: 16px;vertical-align: middle;" src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACQAAAAoCAYAAACWwljjAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAV0SURBVFhH7dZ5TJN3HMfxR6YbQWN0c9MxppKRiU4z54FABh5j4IEooEhZEURFmCJTZBxhoICYeSAoqMxNNjVxKANRYBNBUAE5VShHC8jVAi2UQ8Whgvvt+X5awrJkiTFZ9vyxT/L660n7vNvnedJyrzLGmqaQJw3pniQ9LrSU/HIouIKoKy/uIIzVGxDty/69/edBbCBvKZGlhSSRRK/1A+SM21xG9jmbQ6T3Sjj3jQN85y0eJDWXQlMIe3rflmjf9tUnmCDGmC7JidnIiOk7i+C4uwnkb58Pbe4fgHrXHHiQ6Q3JZ/3A/E0zuHbIGfi9QbSnefkJJoixbv5m7DZ4ejf4JrFbuIaR2GARPA4xBsloXag0mw4yu1lwV2cUDCZaQ1J6LKwzdYQ/pEevEP7B4D9wk672tP88wQQ9Y80zSctVr2fERH81IxtFnjAUPRsqDfWh2nAK3JutDzIbY7g3eSLcHDcW2A132O4XCcuMrKDzdnA76ZLGzCDajJEJLog9iV9I4g77M8Jx++DCERH0bZwKVa+NhZpPpmnoT4aKcROhytQIijkd6HKbCTlZocBxO+FIVAA8rwubS7QZIxNMUHdFrgEZyl13mxw7EsoINzoAMvYuhlbrqSDjXoeaaXwIr9bCUGOxRs20d+Ee/xlJreV0kJYFADfKF0KCg4D1Rt2AgT5DYQZVpPr7koHzZoycS4gEjqOvN5SlJzjD7+EmUM6NgWLRLKg6YQHyPHtojraBirf1oHvXAii/tQuGL1l8TAQwiROoG9MihBnUkBV1iqhOLmCkICUEON1Y2OnhAc/zrSBrtREUWr4P1V7zQOZvDvU+i6D2oDWw1s0QtMUdOC4ICnIOQP/lJaDIO5oozCDZzz5tpD7KlJGHJb5gYHkSRo/xgeu2xtAZbgHVy2dBKX9Dk1q3+SBZ8iEofE1AstUCxr6+DSbP/RYeSQOhOd5MI9WzXphB9ckeT8jdQHNGWMYK2L0/Doa/4kxuArz4SA9qN38MBQ5GUO2/CDrCF8OLOZMgl5sIHPcleIdGAytwBMkBPpgnz/ZuFmaQInNvGnmQuIyRobItIMk+ANx70WDLmUHa+PGQP0UPCme8BWVadatmQpnlHPDWMQFuQjCUZAbCYKUvyK+sA3X5/nihBu27QxpilzLSmrQBWKUnRB5NgOGfEm6Upwa3CezG24H71LUwjnMFjtumFQi7g8OB1blCW4aG/OJK6CoKyv8/6KWClIUhg0R6xpmR2lhHkB/n73zeo1IfqMkLhLgAMewIOgjp5zyhPNkBxG6B4GTnC35fh0P3LQ9Q/mgB9ac/B3nqKuiVhamFGfSsv9iFtGU7MNJw3haqY2w09hjD03xnYPX8f2QiXQ1DBfbQl7oc2H0XjV4fDYkIGiPmQXWMNbRccYDOEjEM9mZYCjNoeEP998VEVeTaR9rz1jNSGWEBNdGfQk/5Vui6Lob2NHtQXhdBX/kWeCjxhsYEa6g7sRJUJT6guOWjJv3KZCuizRiZ4IJ6m4uWkpbL2zqI6o6YQcEmaM90gq68DRoFrqC6yR/n9ZZodOY4Q9NPNtD+mwh6qr6CjnxPaLgg6iLqBz9YEW3GyAQX1N90MIsMtO5hpEfqD62ZbqC46gKqHA355bWgynPT+NUBGk99Bs38g0Har7lo0OXlqcu94LFit4bq2CWizRiZ4IJYe5ke6ZRFHieKbFE/UV5bw8ijYifoubEWVGmrQM0fI8qUFTB8SXuKXECZawedJR7Q3bi3hfQqz4YQxsJ0iDZjZIIL+vtkCX6TSGmkiyu5HWb5PWlMcigk9aftK4k82VFBlBliaLzwRSHpyPHJJl0VJw8TaUrEcsLC+ACe9jR/Gcf9CQVMYQEa9PfrAAAAAElFTkSuQmCC">
        赣公网安备36010902000992
      </a>
    </div>

  </div>
</template>

<script>
export default {
  name: 'Footer',
  props: {
  },
  data() {
    return {
    }
  }
}
</script>

<style scoped>
#footer {
  background-color: gray;
  height: 80px;
  text-align: center;
}

#footer a {
  color: #cfd2d4;
  text-decoration: none;
  line-height: 40px;
}
</style>