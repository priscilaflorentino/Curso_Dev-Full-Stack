import styled from "styled-components";

export const Container =  styled.div`
    width: 100%;
    height: 100vh;
    background-color: #CACACA;

    align-items: center;
    justify-content: center;
    display: flex;
`

export const Content = styled.div`
    width: 30%;
    min-height: 225px;
    background-color: #FFFFFF;
`
export const Row = styled.div`
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
`
export const Column = styled.div`
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: center;
`